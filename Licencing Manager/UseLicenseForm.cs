using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Portable.Licensing;
using Portable.Licensing.Validation;

namespace Licencing_Manager
{
    public partial class UseLicenseForm : Form
    {
        public event EventHandler OnLicenseValidated = null;
        private License license;

        private UseLicenseForm()
        {
            InitializeComponent();
        }

        public UseLicenseForm(string publickKey, License license)
        {
            InitializeComponent();
            txtPublicKey.Text = publickKey;
            this.license = license;
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            IEnumerable<IValidationFailure> validationFailures;
            // Usare un sequence così da evitare problemi di concorrenza sul DB
            int used = int.Parse(license.AdditionalAttributes.Get("Used"));

            Guid id;
            if (!Guid.TryParse(txtLicenseID.Text, out id) || license.Id != id)
            {
                listValidation.Items.Add($"ID Licenza {txtLicenseID.Text} non valido");
                return;
            }

            string host = $"{Environment.MachineName}{(SystemInformation.TerminalServerSession ? "." + Environment.UserName : string.Empty)}";
            string hash = host.GetHashCode().ToString();
            if (license.AdditionalAttributes.Get(hash) == null)
            {
                if (license.Type == LicenseType.Trial)
                {

                    validationFailures = license.Validate()
                                        .ExpirationDate()
                                            .When(lic => lic.Type == LicenseType.Trial)
                                        .And()
                                        .Signature(txtPublicKey.Text)
                                        .And()
                                        .AssertThat(l => used < l.Quantity, new GeneralValidationFailure() { Message = "E' stato raggiunto il numero massimo di licenze utilizzate", HowToResolve = "Acquistare un nuovo set di licenze" })
                                        .AssertValidLicense();
                }
                else
                {
                    validationFailures = license.Validate()
                                        .Signature(txtPublicKey.Text)
                                        .And()
                                        .AssertThat(l => used < l.Quantity, new GeneralValidationFailure() { Message = "E' stato raggiunto il numero massimo di licenze utilizzate", HowToResolve = "Acquistare un nuovo set di licenze" })
                                        .AssertValidLicense();
                }
                foreach (var valid in validationFailures)
                {
                    listValidation.Items.Add(valid.Message);
                    listValidation.Items.Add("\t" + valid.HowToResolve);
                }
                if (listValidation.Items.Count == 0)
                {
                    used++;
                    license.AdditionalAttributes.Remove("Used");
                    license.AdditionalAttributes.Add("Used", used.ToString());
                    license.AdditionalAttributes.Add(hash, $"1 - {host}\t{txtUsername.Text}: {txtMail.Text}");
                    bool validL = license.VerifySignature(txtPublicKey.Text);

                    OnLicenseValidated?.Invoke(null, EventArgs.Empty);

                    validL = license.VerifySignature(txtPublicKey.Text);
                    listValidation.Items.Add("ATTIVATO");
                    btnActivate.Enabled = false;
                }
            }
            else
            {
                listValidation.Items.Add("GIA' ATTIVATO");
                btnActivate.Enabled = false;
            }
        }
    }
}
