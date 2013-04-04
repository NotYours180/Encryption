using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Encryption.Properties;

namespace Encryption
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();      
        }

        protected Encryption Encryption;

        protected virtual void btnEncrypt_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected virtual void btnDecrypt_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnLoadKey_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog { Filter = Resources.resOPTxt };
            if (open.ShowDialog() != DialogResult.OK) return;
            try
            {
                using (var sr = new StreamReader(open.FileName, Encoding.GetEncoding(1251)))
                {
                    tbKey.Text = sr.ReadToEnd();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка: невозможно прочитать файл с диска.");
            }
        }

        protected virtual void btnLoadData_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog { Filter = Resources.resOPTxt };
            if (open.ShowDialog() != DialogResult.OK) return;
            try
            {
                using (var sr = new StreamReader(open.FileName, Encoding.GetEncoding(1251)))
                {
                    rtbInput.Text = sr.ReadToEnd();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка: невозможно прочитать файл с диска.");
            }
        }
    }
}
