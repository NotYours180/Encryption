using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Encryption
{
    partial class EncryptionMethodForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.btnLoadForm = new Button();
            this.lblEncryptionMethod = new Label();
            this.cmbEncryprionMethod = new ComboBox();
            this.SuspendLayout();
            // 
            // btnLoadForm
            // 
            this.btnLoadForm.Location = new Point(214, 12);
            this.btnLoadForm.Name = "btnLoadForm";
            this.btnLoadForm.Size = new Size(80, 38);
            this.btnLoadForm.TabIndex = 17;
            this.btnLoadForm.Text = "Выбрать";
            this.btnLoadForm.UseVisualStyleBackColor = true;
            this.btnLoadForm.Click += new EventHandler(this.btnLoadForm_Click);
            // 
            // lblEncryptionMethod
            // 
            this.lblEncryptionMethod.AutoSize = true;
            this.lblEncryptionMethod.Location = new Point(12, 24);
            this.lblEncryptionMethod.Name = "lblEncryptionMethod";
            this.lblEncryptionMethod.Size = new Size(109, 13);
            this.lblEncryptionMethod.TabIndex = 16;
            this.lblEncryptionMethod.Text = "Метод шифрования:";
            // 
            // cmbEncryprionMethod
            // 
            this.cmbEncryprionMethod.DrawMode = DrawMode.OwnerDrawFixed;
            this.cmbEncryprionMethod.FormattingEnabled = true;
            this.cmbEncryprionMethod.Location = new Point(127, 21);
            this.cmbEncryprionMethod.Name = "cmbEncryprionMethod";
            this.cmbEncryprionMethod.Size = new Size(83, 21);
            this.cmbEncryprionMethod.TabIndex = 15;
            // 
            // EncryptionMethodForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.ClientSize = new Size(306, 62);
            this.Controls.Add(this.btnLoadForm);
            this.Controls.Add(this.lblEncryptionMethod);
            this.Controls.Add(this.cmbEncryprionMethod);
            this.Name = "EncryptionMethodForm";
            this.Text = "EncryptionMethodForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLoadForm;
        protected Label lblEncryptionMethod;
        protected ComboBox cmbEncryprionMethod;
    }
}