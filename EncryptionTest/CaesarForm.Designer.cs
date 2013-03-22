namespace Encryption
{
    partial class CaesarForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnHack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbInput
            // 
            this.rtbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbInput.Location = new System.Drawing.Point(13, 13);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(259, 87);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "Dennis";
            // 
            // rtbOutput
            // 
            this.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbOutput.Location = new System.Drawing.Point(13, 106);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(260, 87);
            this.rtbOutput.TabIndex = 1;
            this.rtbOutput.Text = "";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(182, 199);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(91, 23);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Зашифровать";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // tbKey
            // 
            this.tbKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKey.Location = new System.Drawing.Point(54, 202);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(122, 20);
            this.tbKey.TabIndex = 3;
            this.tbKey.Text = "3";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(12, 204);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(36, 13);
            this.lblKey.TabIndex = 4;
            this.lblKey.Text = "Ключ:";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(182, 228);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(91, 23);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Расшифровать";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnHack
            // 
            this.btnHack.Location = new System.Drawing.Point(89, 228);
            this.btnHack.Name = "btnHack";
            this.btnHack.Size = new System.Drawing.Size(87, 23);
            this.btnHack.TabIndex = 6;
            this.btnHack.Text = "Дешифровать";
            this.btnHack.UseVisualStyleBackColor = true;
            this.btnHack.Click += new System.EventHandler(this.btnHack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Enabled = false;
            this.btnForward.Location = new System.Drawing.Point(41, 228);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(23, 23);
            this.btnForward.TabIndex = 7;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Enabled = false;
            this.btnBackward.Location = new System.Drawing.Point(12, 228);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(23, 23);
            this.btnBackward.TabIndex = 8;
            this.btnBackward.Text = "<";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // Caesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 255);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnHack);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.rtbInput);
            this.Name = "Caesar";
            this.Text = "Шифр Цезаря";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox rtbInput;
        public System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnHack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackward;

    }
}

