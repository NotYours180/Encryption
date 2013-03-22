using System;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Encryption
{
    public partial class GammaForm : Form
    {
        public GammaForm()
        {
            InitializeComponent();
        }

        private Encryption _encryption;

        private void btnLoadMessage_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog {Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"};
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

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            _encryption = new Gamma(rtbInput.Text, tbKey.Text);
            tbKey.Clear();
            rtbOutput.Clear();
            rtbOutput.Text = _encryption.Encrypt();
            tbKey.Text = _encryption.Key;
            using (var file = new StreamWriter("key.txt"))
            {
                file.WriteLine(_encryption.Key);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            _encryption = new Gamma(rtbInput.Text, tbKey.Text);
            rtbOutput.Clear();
            rtbOutput.Text = _encryption.Decrypt();
        }

        private void btnLoadKey_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog {Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"};
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
    }
}
