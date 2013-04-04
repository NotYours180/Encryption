using System;
using System.IO;
using System.Windows.Forms;
using Encryption.Properties;

namespace Encryption
{
    public partial class DesForm : BaseForm
    {
        public DES DESEncryption;
        public DesForm()
        {
            InitializeComponent();   
        }
        protected override void btnEncrypt_Click(object sender, EventArgs e)
        {
            using (var saveKeyFile = new OpenFileDialog { Filter = Resources.resOPKey})
            {
                if (saveKeyFile.ShowDialog() != DialogResult.OK) return;
                using (var saveEncFile = new SaveFileDialog { Filter = Resources.resOPTxt })
                {
                    if (saveEncFile.ShowDialog() != DialogResult.OK) return;
                    DESEncryption = new DES(rtbInput.Text, tbKey.Text);
                    DESEncryption.Encrypt(saveEncFile.FileName, saveKeyFile.FileName, rtbInput.Text);
                }
            }
        }

        protected override void btnLoadData_Click(object sender, EventArgs e)
        {
            using (var file = new OpenFileDialog())
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    rtbInput.Text = file.FileName;
                }
            }
            
        }

        protected override void btnDecrypt_Click(object sender, EventArgs e)
        {
            using (var openKeyFile = new OpenFileDialog {Filter = Resources.resOPKey})
            {
                if (openKeyFile.ShowDialog() == DialogResult.OK)
                {
                    using (var saveDecFile = new SaveFileDialog { Filter = Resources.resOPTxt })
                    {
                        if (saveDecFile.ShowDialog() == DialogResult.OK)
                        {
                            DESEncryption = new DES(rtbInput.Text, tbKey.Text);
                            DESEncryption.Decrypt(saveDecFile.FileName, openKeyFile.FileName, rtbInput.Text);
                        }
                    }
                }
            }
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            using (var saveKeyFile = new SaveFileDialog {Filter = Resources.resOPKey})
            {
                if (saveKeyFile.ShowDialog() == DialogResult.OK)
                {
                    var fsFileOut = File.Create(saveKeyFile.FileName);
                    var sw = new StreamWriter(fsFileOut);
                    sw.Write(DES.GenerateKey());
                    sw.Close();
                }
            }  
        }
    }
}
