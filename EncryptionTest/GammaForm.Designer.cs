namespace Encryption
{
    partial class GammaForm
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
            this.btnLoadMessage = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.btnLoadKey = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLoadMessage
            // 
            this.btnLoadMessage.Location = new System.Drawing.Point(138, 214);
            this.btnLoadMessage.Name = "btnLoadMessage";
            this.btnLoadMessage.Size = new System.Drawing.Size(131, 23);
            this.btnLoadMessage.TabIndex = 13;
            this.btnLoadMessage.Text = "Загрузить сообщение";
            this.btnLoadMessage.UseVisualStyleBackColor = true;
            this.btnLoadMessage.Click += new System.EventHandler(this.btnLoadMessage_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(275, 243);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(93, 23);
            this.btnDecode.TabIndex = 11;
            this.btnDecode.Text = "Расшифровать";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(275, 214);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(93, 23);
            this.btnEncode.TabIndex = 10;
            this.btnEncode.Text = "Зашифровать";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(12, 114);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(356, 96);
            this.rtbOutput.TabIndex = 9;
            this.rtbOutput.Text = "";
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(12, 12);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(356, 96);
            this.rtbInput.TabIndex = 8;
            this.rtbInput.Text = "";
            // 
            // btnLoadKey
            // 
            this.btnLoadKey.Location = new System.Drawing.Point(12, 243);
            this.btnLoadKey.Name = "btnLoadKey";
            this.btnLoadKey.Size = new System.Drawing.Size(120, 23);
            this.btnLoadKey.TabIndex = 14;
            this.btnLoadKey.Text = "Загрузить ключ";
            this.btnLoadKey.UseVisualStyleBackColor = true;
            this.btnLoadKey.Click += new System.EventHandler(this.btnLoadKey_Click);
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(12, 216);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(120, 20);
            this.tbKey.TabIndex = 15;
            // 
            // GammaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 278);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.btnLoadKey);
            this.Controls.Add(this.btnLoadMessage);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.rtbInput);
            this.Name = "GammaForm";
            this.Text = "GammaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadMessage;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Button btnLoadKey;
        private System.Windows.Forms.TextBox tbKey;
    }
}