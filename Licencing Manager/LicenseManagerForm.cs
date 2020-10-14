using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Portable.Licensing;

namespace Licencing_Manager
{
    public partial class LicenseManagerForm : Form
    {
        protected const string PASS_PHRASE = "G7 International s.r.l. - G7 Suite license";

        private Portable.Licensing.License license;

        public LicenseManagerForm()
        {
            InitializeComponent();
        }

        private void btnCreaLicenza_Click(object sender, EventArgs e)
        {
            var keyGenerator = Portable.Licensing.Security.Cryptography.KeyGenerator.Create();
            var keyPair = keyGenerator.GenerateKeyPair();
            txtPrivateKey.Text = keyPair.ToEncryptedPrivateKeyString(PASS_PHRASE);
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

            if (tipo == LicenseType.Trial)
            {
                int days = 30;
                int.TryParse(txtValidity.Text, out days);
                if (days <= 30)
                    days = 30;

                license = Portable.Licensing.License.New()
                    .WithUniqueIdentifier(Guid.NewGuid())
                    .As(tipo)
                    .ExpiresAt(DateTime.Now.AddDays(days))
                    .WithMaximumUtilization(utilizzi)
                    .WithProductFeatures(new Dictionary<string, string>
                    {
                        {"Sales Module", "yes"},
                        {"Purchase Module", "yes"},
                        {"Maximum Transactions", "10000"}
                    })
                    .LicensedTo(txtUse.Text, txtMail.Text)
                    .CreateAndSignWithPrivateKey(txtPrivateKey.Text, PASS_PHRASE);
            }
            else 
            {
                license = Portable.Licensing.License.New()
                    .WithUniqueIdentifier(Guid.NewGuid())
                    .As(tipo)
                    .WithMaximumUtilization(utilizzi)
                    .WithProductFeatures(new Dictionary<string, string>
                    {
                        {"Sales Module", "yes"},
                        {"Purchase Module", "yes"},
                        {"Maximum Transactions", "10000"}
                    })
                    // Usare un sequence così da evitare problemi di concorrenza sul DB
                    .WithAdditionalAttributes(new Dictionary<string, string>
                    {
                        {"Used", "0"},
                    })
                    .LicensedTo(txtUsername.Text, txtMail.Text)
                    .CreateAndSignWithPrivateKey(txtPrivateKey.Text, PASS_PHRASE);
            }

            txtLicense.Text = license.ToString();
        }

        private void btnUseLicense_Click(object sender, EventArgs e)
        {
            UseLicenseForm f = new UseLicenseForm(txtPublicKey.Text, license);
            f.Show(this);
        }
    }
}
