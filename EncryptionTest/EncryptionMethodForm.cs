using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Encryption
{
    public partial class EncryptionMethodForm : Form
    {
        public EncryptionMethodForm()
        {
            InitializeComponent();
            cmbEncryprionMethod.DataSource = new List<EncryptionMethod>
                {
                    EncryptionMethod.DES,
                    EncryptionMethod.Caesar,
                    EncryptionMethod.Tritemius,
                    EncryptionMethod.Gamma        
                };
        }

        public enum EncryptionMethod
        {
            Caesar,
            Tritemius,
            Gamma,
            DES
        }

        private void btnLoadForm_Click(object sender, EventArgs e)
        {
            var encMethod = (EncryptionMethod)cmbEncryprionMethod.SelectedValue;
            if (cmbEncryprionMethod != null)
                switch (encMethod)
                {
                    case EncryptionMethod.Caesar:
                        break;
                    case EncryptionMethod.DES:
                        var encryptionForm = new DesForm();
                        encryptionForm.Show();
                        break;
                    case EncryptionMethod.Gamma:
                        break;
                    case EncryptionMethod.Tritemius:
                        break;
                }
            Hide();
        }
    }
}
