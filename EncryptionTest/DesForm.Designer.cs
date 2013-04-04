namespace Encryption
{
    partial class DesForm
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
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Location = new System.Drawing.Point(206, 197);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(95, 23);
            this.btnGenerateKey.TabIndex = 14;
            this.btnGenerateKey.Text = "Сгенерировать";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // DesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(310, 254);
            this.Controls.Add(this.btnGenerateKey);
            this.Name = "DesForm";
            this.Text = "DesForm";
            this.Controls.SetChildIndex(this.rtbInput, 0);
            this.Controls.SetChildIndex(this.rtbOutput, 0);
            this.Controls.SetChildIndex(this.btnEncrypt, 0);
            this.Controls.SetChildIndex(this.tbKey, 0);
            this.Controls.SetChildIndex(this.lblKey, 0);
            this.Controls.SetChildIndex(this.btnDecrypt, 0);
            this.Controls.SetChildIndex(this.btnGenerateKey, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateKey;

    }
}