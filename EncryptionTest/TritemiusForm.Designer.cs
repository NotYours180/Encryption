namespace Encryption
{
    partial class TritemiusForm
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
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.cmbEncryptionType = new System.Windows.Forms.ComboBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(12, 13);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(260, 96);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(12, 115);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(260, 96);
            this.rtbOutput.TabIndex = 1;
            this.rtbOutput.Text = "";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(179, 217);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(93, 23);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Зашифровать";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(179, 246);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(93, 23);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Расшифровать";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // cmbEncryptionType
            // 
            this.cmbEncryptionType.CausesValidation = false;
            this.cmbEncryptionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncryptionType.FormattingEnabled = true;
            this.cmbEncryptionType.IntegralHeight = false;
            this.cmbEncryptionType.Location = new System.Drawing.Point(12, 248);
            this.cmbEncryptionType.Name = "cmbEncryptionType";
            this.cmbEncryptionType.Size = new System.Drawing.Size(81, 21);
            this.cmbEncryptionType.TabIndex = 4;
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(12, 219);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(133, 20);
            this.tbKey.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddX_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(99, 246);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(74, 23);
            this.btnLoadFile.TabIndex = 7;
            this.btnLoadFile.Text = "Загрузить";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // TritemiusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 278);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.cmbEncryptionType);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.rtbInput);
            this.Name = "TritemiusForm";
            this.Text = "Tritemus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.ComboBox cmbEncryptionType;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLoadFile;
    }
}