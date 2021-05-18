using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Portable.Licensing;
using Portable.Licensing.Security.Cryptography;

namespace Licencing_Manager
{
    public partial class LicenseManagerForm : Form
    {
        private const string PASS_PHRASE = "G7 International s.r.l. - G7 Suite license";

        private License license;

        public LicenseManagerForm()
        {
            InitializeComponent();
        }

        private void btnCreaLicenza_Click(object sender, EventArgs e)
        {
            Guid id;
            if (!Guid.TryParse(txtClientId.Text, out id))
            {
                MessageBox.Show("Id Cliente {txtClientId.Text} non valido", this.Text);
                return;
            }

            var keyGenerator = KeyGenerator.Create();
            var keyPair = keyGenerator.GenerateKeyPair();
            txtPrivateKey.Text = keyPair.ToEncryptedPrivateKeyString(PASS_PHRASE + "." + txtClientId.Text);
            txtPublicKey.Text = keyPair.ToPublicKeyString();
        }

        private void rbTrial_CheckedChanged(object sender, EventArgs e)
        {
            lblValidity.Enabled = txtValidity.Enabled = rbTrial.Checked;
        }

        private void rbRemote_CheckedChanged(object sender, EventArgs e)
        {
            lblUse.Enabled = txtUse.Enabled = rbRemote.Checked;
        }

        private void btnCreaLicenza_Click_1(object sender, EventArgs e)
        {
            LicenseType tipo = rbStandard.Checked ? LicenseType.Standard : LicenseType.Trial;
            int utilizzi = 1;
            if (rbRemote.Checked)
            {
                int.TryParse(txtUse.Text, out utilizzi);
                if (utilizzi <= 0)
                    utilizzi = 1;
            }
            Guid id;
            if (!Guid.TryParse(txtClientId.Text, out id))
            {
                MessageBox.Show("Id Cliente {txtClientId.Text} non valido", this.Text);
                return;
            }
            ILicenseBuilder builder = null;
            if (tipo == LicenseType.Trial)
            {
                int days = 30;
                int.TryParse(txtValidity.Text, out days);
                if (days <= 30)
                    days = 30;

                builder = License.New()
                    .WithUniqueIdentifier(Guid.NewGuid())
                    .As(tipo)
                    .ExpiresAt(DateTime.Now.AddDays(days)).WithAdditionalAttributes(new Dictionary<string, string>
                    {
                        {"ClientId", id.ToString()}
                    }); ;

            }
            else 
            {
                builder = License.New()
                    .WithUniqueIdentifier(Guid.NewGuid())
                    .As(tipo)
                    // Usare un sequence così da evitare problemi di concorrenza sul DB
                    .WithAdditionalAttributes(new Dictionary<string, string>
                    {
                        {"Used", "0"},
                        {"ClientId", id.ToString()}
                    });
            }
            license = builder.WithMaximumUtilization(utilizzi)
                .WithProductFeatures(new Dictionary<string, string>
                    {
                        {"Contabilità", checkContabilità.Checked ? "1" : "0"},
                        {"Documenti", checkDocumenti.Checked ? "1" : "0"},
                        {"Magazzino", checkMagazzino.Checked ? "1" : "0"},
                        {"Manutenzioni", checkManutenzioni.Checked ? "1" : "0"}
                    })
                .LicensedTo(txtUsername.Text, txtMail.Text)
                .CreateAndSignWithPrivateKey(txtPrivateKey.Text, PASS_PHRASE + "." + txtClientId.Text);
            txtLicense.Text = license.ToString();
        }

        private void btnUseLicense_Click(object sender, EventArgs e)
        {
            UseLicenseForm f = new UseLicenseForm(txtPublicKey.Text, license);
            f.OnLicenseValidated += F_OnLicenseValidated;
            f.Show(this);
        }

        private void F_OnLicenseValidated(object sender, EventArgs e)
        {
            license.Sign(txtPrivateKey.Text, PASS_PHRASE + "." + txtClientId.Text);
            txtLicense.Text = license.ToString();
        }
    }
}
