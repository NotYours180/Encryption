using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Encryption
{
    public partial class TritemiusForm : Form
    {
        public TritemiusForm()
        {
            InitializeComponent();
            cmbEncryptionType.DataSource = new object[]
            {
                Tritemius.OffsetType.Expression,
                Tritemius.OffsetType.Slogan
            };
        }

        private Encryption _encryption;
        private Tritemius.OffsetType _type;

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            _type = (Tritemius.OffsetType)cmbEncryptionType.SelectedItem;
            _encryption = new Tritemius(rtbInput.Text, tbKey.Text, _type);
            rtbOutput.Clear();
            rtbOutput.Text = _encryption.Encrypt();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            _encryption = new Tritemius(rtbInput.Text, tbKey.Text, _type);
            rtbOutput.Clear();
            rtbOutput.Text = _encryption.Decrypt();
        }

        private void btnAddX_Click(object sender, EventArgs e)
        {
            tbKey.Text += "x";
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
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
}
