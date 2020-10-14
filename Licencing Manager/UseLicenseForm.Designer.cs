namespace Licencing_Manager
{
    partial class UseLicenseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActivate = new System.Windows.Forms.Button();
            this.listValidation = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(104, 6);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.ReadOnly = true;
            this.txtPublicKey.Size = new System.Drawing.Size(717, 153);
            this.txtPublicKey.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chiave pubblica:";
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(631, 165);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(190, 40);
            this.btnActivate.TabIndex = 5;
            this.btnActivate.Text = "Attiva";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // listValidation
            // 
            this.listValidation.FormattingEnabled = true;
            this.listValidation.Location = new System.Drawing.Point(12, 211);
            this.listValidation.Name = "listValidation";
            this.listValidation.Size = new System.Drawing.Size(809, 303);
            this.listValidation.TabIndex = 6;
            // 
            // UseLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 523);
            this.Controls.Add(this.listValidation);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.txtPublicKey);
            this.Controls.Add(this.label1);
            this.Name = "UseLicenseForm";
            this.Text = "UseLicenseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.ListBox listValidation;
    }
}