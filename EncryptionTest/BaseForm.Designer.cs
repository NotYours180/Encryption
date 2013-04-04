namespace Encryption
{
    partial class BaseForm
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
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(109, 226);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(91, 23);
            this.btnDecrypt.TabIndex = 11;
            this.btnDecrypt.Text = "Расшифровать";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(12, 226);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(91, 23);
            this.btnEncrypt.TabIndex = 8;
            this.btnEncrypt.Text = "Зашифровать";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbOutput.Location = new System.Drawing.Point(12, 105);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(286, 87);
            this.rtbOutput.TabIndex = 7;
            this.rtbOutput.Text = "";
            // 
            // rtbInput
            // 
            this.rtbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbInput.Location = new System.Drawing.Point(12, 12);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(286, 87);
            this.rtbInput.TabIndex = 6;
            this.rtbInput.Text = "";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(206, 226);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(95, 23);
            this.btnLoadData.TabIndex = 15;
            this.btnLoadData.Text = "Обзор";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(11, 202);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(36, 13);
            this.lblKey.TabIndex = 10;
            this.lblKey.Text = "Ключ:";
            // 
            // tbKey
            // 
            this.tbKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKey.Location = new System.Drawing.Point(53, 200);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(122, 20);
            this.tbKey.TabIndex = 9;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 255);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.rtbInput);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        protected System.Windows.Forms.Button btnDecrypt;
        protected System.Windows.Forms.Button btnEncrypt;
        public System.Windows.Forms.RichTextBox rtbOutput;
        public System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Button btnLoadData;
        protected System.Windows.Forms.Label lblKey;
        protected System.Windows.Forms.TextBox tbKey;
    }
}