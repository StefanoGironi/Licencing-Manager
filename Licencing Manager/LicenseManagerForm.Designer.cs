namespace Licencing_Manager
{
    partial class LicenseManagerForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreaChiavi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValidity = new System.Windows.Forms.TextBox();
            this.lblValidity = new System.Windows.Forms.Label();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTrial = new System.Windows.Forms.RadioButton();
            this.txtUse = new System.Windows.Forms.TextBox();
            this.lblUse = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbRemote = new System.Windows.Forms.RadioButton();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.btnCreaLicenza = new System.Windows.Forms.Button();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUseLicense = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkManutenzioni = new System.Windows.Forms.CheckBox();
            this.checkMagazzino = new System.Windows.Forms.CheckBox();
            this.checkDocumenti = new System.Windows.Forms.CheckBox();
            this.checkContabilità = new System.Windows.Forms.CheckBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreaChiavi
            // 
            this.btnCreaChiavi.Location = new System.Drawing.Point(827, 12);
            this.btnCreaChiavi.Name = "btnCreaChiavi";
            this.btnCreaChiavi.Size = new System.Drawing.Size(133, 35);
            this.btnCreaChiavi.TabIndex = 0;
            this.btnCreaChiavi.Text = "Crea Chiavi";
            this.btnCreaChiavi.UseVisualStyleBackColor = true;
            this.btnCreaChiavi.Click += new System.EventHandler(this.btnCreaLicenza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chiave pubblica:";
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(104, 12);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(717, 106);
            this.txtPublicKey.TabIndex = 2;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(104, 124);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(717, 131);
            this.txtPrivateKey.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chiave privata:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Utente";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(104, 261);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(159, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(301, 261);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(159, 20);
            this.txtMail.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mail";
            // 
            // txtValidity
            // 
            this.txtValidity.Enabled = false;
            this.txtValidity.Location = new System.Drawing.Point(162, 41);
            this.txtValidity.Name = "txtValidity";
            this.txtValidity.Size = new System.Drawing.Size(86, 20);
            this.txtValidity.TabIndex = 10;
            // 
            // lblValidity
            // 
            this.lblValidity.AutoSize = true;
            this.lblValidity.Enabled = false;
            this.lblValidity.Location = new System.Drawing.Point(86, 44);
            this.lblValidity.Name = "lblValidity";
            this.lblValidity.Size = new System.Drawing.Size(70, 13);
            this.lblValidity.TabIndex = 9;
            this.lblValidity.Text = "Giorni validità";
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Checked = true;
            this.rbStandard.Location = new System.Drawing.Point(6, 19);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(68, 17);
            this.rbStandard.TabIndex = 11;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "Standard";
            this.rbStandard.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTrial);
            this.groupBox1.Controls.Add(this.txtValidity);
            this.groupBox1.Controls.Add(this.lblValidity);
            this.groupBox1.Controls.Add(this.rbStandard);
            this.groupBox1.Location = new System.Drawing.Point(12, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 74);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo di licenza";
            // 
            // rbTrial
            // 
            this.rbTrial.AutoSize = true;
            this.rbTrial.Location = new System.Drawing.Point(6, 42);
            this.rbTrial.Name = "rbTrial";
            this.rbTrial.Size = new System.Drawing.Size(53, 17);
            this.rbTrial.TabIndex = 12;
            this.rbTrial.Text = "Prova";
            this.rbTrial.UseVisualStyleBackColor = true;
            this.rbTrial.CheckedChanged += new System.EventHandler(this.rbTrial_CheckedChanged);
            // 
            // txtUse
            // 
            this.txtUse.Enabled = false;
            this.txtUse.Location = new System.Drawing.Point(167, 41);
            this.txtUse.Name = "txtUse";
            this.txtUse.Size = new System.Drawing.Size(57, 20);
            this.txtUse.TabIndex = 14;
            // 
            // lblUse
            // 
            this.lblUse.AutoSize = true;
            this.lblUse.Enabled = false;
            this.lblUse.Location = new System.Drawing.Point(74, 44);
            this.lblUse.Name = "lblUse";
            this.lblUse.Size = new System.Drawing.Size(87, 13);
            this.lblUse.TabIndex = 13;
            this.lblUse.Text = "Numero di Utilizzi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUse);
            this.groupBox2.Controls.Add(this.rbRemote);
            this.groupBox2.Controls.Add(this.lblUse);
            this.groupBox2.Controls.Add(this.rbLocal);
            this.groupBox2.Location = new System.Drawing.Point(281, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 74);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo di utilizzo";
            // 
            // rbRemote
            // 
            this.rbRemote.AutoSize = true;
            this.rbRemote.Location = new System.Drawing.Point(6, 42);
            this.rbRemote.Name = "rbRemote";
            this.rbRemote.Size = new System.Drawing.Size(62, 17);
            this.rbRemote.TabIndex = 12;
            this.rbRemote.Text = "Remota";
            this.rbRemote.UseVisualStyleBackColor = true;
            this.rbRemote.CheckedChanged += new System.EventHandler(this.rbRemote_CheckedChanged);
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.Checked = true;
            this.rbLocal.Location = new System.Drawing.Point(6, 19);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(57, 17);
            this.rbLocal.TabIndex = 11;
            this.rbLocal.TabStop = true;
            this.rbLocal.Text = "Locale";
            this.rbLocal.UseVisualStyleBackColor = true;
            // 
            // btnCreaLicenza
            // 
            this.btnCreaLicenza.Location = new System.Drawing.Point(380, 367);
            this.btnCreaLicenza.Name = "btnCreaLicenza";
            this.btnCreaLicenza.Size = new System.Drawing.Size(133, 35);
            this.btnCreaLicenza.TabIndex = 16;
            this.btnCreaLicenza.Text = "Crea Licenza";
            this.btnCreaLicenza.UseVisualStyleBackColor = true;
            this.btnCreaLicenza.Click += new System.EventHandler(this.btnCreaLicenza_Click_1);
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(104, 408);
            this.txtLicense.Multiline = true;
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.ReadOnly = true;
            this.txtLicense.Size = new System.Drawing.Size(717, 231);
            this.txtLicense.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Licenza:";
            // 
            // btnUseLicense
            // 
            this.btnUseLicense.Location = new System.Drawing.Point(688, 645);
            this.btnUseLicense.Name = "btnUseLicense";
            this.btnUseLicense.Size = new System.Drawing.Size(133, 35);
            this.btnUseLicense.TabIndex = 19;
            this.btnUseLicense.Text = "Testa Licenza";
            this.btnUseLicense.UseVisualStyleBackColor = true;
            this.btnUseLicense.Click += new System.EventHandler(this.btnUseLicense_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkManutenzioni);
            this.groupBox3.Controls.Add(this.checkMagazzino);
            this.groupBox3.Controls.Add(this.checkDocumenti);
            this.groupBox3.Controls.Add(this.checkContabilità);
            this.groupBox3.Location = new System.Drawing.Point(519, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 74);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Moduli";
            // 
            // checkManutenzioni
            // 
            this.checkManutenzioni.AutoSize = true;
            this.checkManutenzioni.Location = new System.Drawing.Point(89, 42);
            this.checkManutenzioni.Name = "checkManutenzioni";
            this.checkManutenzioni.Size = new System.Drawing.Size(89, 17);
            this.checkManutenzioni.TabIndex = 3;
            this.checkManutenzioni.Text = "Manutenzioni";
            this.checkManutenzioni.UseVisualStyleBackColor = true;
            // 
            // checkMagazzino
            // 
            this.checkMagazzino.AutoSize = true;
            this.checkMagazzino.Location = new System.Drawing.Point(89, 19);
            this.checkMagazzino.Name = "checkMagazzino";
            this.checkMagazzino.Size = new System.Drawing.Size(77, 17);
            this.checkMagazzino.TabIndex = 2;
            this.checkMagazzino.Text = "Magazzino";
            this.checkMagazzino.UseVisualStyleBackColor = true;
            // 
            // checkDocumenti
            // 
            this.checkDocumenti.AutoSize = true;
            this.checkDocumenti.Location = new System.Drawing.Point(6, 42);
            this.checkDocumenti.Name = "checkDocumenti";
            this.checkDocumenti.Size = new System.Drawing.Size(77, 17);
            this.checkDocumenti.TabIndex = 1;
            this.checkDocumenti.Text = "Documenti";
            this.checkDocumenti.UseVisualStyleBackColor = true;
            // 
            // checkContabilità
            // 
            this.checkContabilità.AutoSize = true;
            this.checkContabilità.Location = new System.Drawing.Point(6, 19);
            this.checkContabilità.Name = "checkContabilità";
            this.checkContabilità.Size = new System.Drawing.Size(75, 17);
            this.checkContabilità.TabIndex = 0;
            this.checkContabilità.Text = "Contabilità";
            this.checkContabilità.UseVisualStyleBackColor = true;
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(511, 261);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(310, 20);
            this.txtClientId.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cliente";
            // 
            // LicenseManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 692);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnUseLicense);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCreaLicenza);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPublicKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreaChiavi);
            this.Name = "LicenseManagerForm";
            this.Text = "License manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreaChiavi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValidity;
        private System.Windows.Forms.Label lblValidity;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTrial;
        private System.Windows.Forms.TextBox txtUse;
        private System.Windows.Forms.Label lblUse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbRemote;
        private System.Windows.Forms.RadioButton rbLocal;
        private System.Windows.Forms.Button btnCreaLicenza;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUseLicense;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkManutenzioni;
        private System.Windows.Forms.CheckBox checkMagazzino;
        private System.Windows.Forms.CheckBox checkDocumenti;
        private System.Windows.Forms.CheckBox checkContabilità;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label label6;
    }
}

