﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private Portable.Licensing.License license;

        public UseLicenseForm()
        {
            InitializeComponent();
        }

        public UseLicenseForm(string publickKey, Portable.Licensing.License license)
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
            if (license.Type == LicenseType.Trial)
            {

                validationFailures = license.Validate()
                                    .ExpirationDate()
                                        .When(lic => lic.Type == LicenseType.Trial)
                                    .And()
                                    .Signature(txtPublicKey.Text)
                                    .And()
                                    .AssertThat(l => used < l.Quantity, new GeneralValidationFailure() { Message = "E' stato raggiunto il niumero massimo di licenze usilizzate", HowToResolve = "Acquistare un nuovo set di licenze" })
                                    .AssertValidLicense();
            }
            else
            {
                validationFailures = license.Validate()
                                    .Signature(txtPublicKey.Text)
                                    .And()
                                    .AssertThat(l => used < l.Quantity, new GeneralValidationFailure() { Message = "E' stato raggiunto il niumero massimo di licenze usilizzate", HowToResolve = "Acquistare un nuovo set di licenze" })
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
                license.AdditionalAttributes.RemoveAll();
                license.AdditionalAttributes.Add("Used", used.ToString());
            }

        }
    }
}