using System;
using System.Linq;
using System.Windows.Forms;

namespace Encryption
{
    public partial class CaesarForm : Form
    {
        public CaesarForm()
        {
            InitializeComponent();
        }

        Encryption _encryption;
        private int _counter;
     
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            _encryption = new Caesar(rtbInput.Text, tbKey.Text);
            try
            {
               rtbOutput.Text = _encryption.Decrypt();
            }
            catch 
            { 
                MessageBox.Show("Данные введены неверно!"); 
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            _encryption = new Caesar(rtbInput.Text, tbKey.Text);
            try
            {
                rtbOutput.Text = _encryption.Decrypt();
            }
            catch
            {
                MessageBox.Show("Данные введены неверно!");
            }
        }

        private void btnHack_Click(object sender, EventArgs e)
        {
            _encryption = new Caesar(rtbInput.Text, tbKey.Text);

            if (_encryption.InputLang == Encryption.Language.Undefined) 
            {
                throw new Exception("Ошибка. Один или несколько символов введены неверно.");
            }
            if (_encryption.InputLang == Encryption.Language.Different)
            {
                throw new Exception("Ошибка. Нельзя использовать более одного языка в тексте.");
            }

            btnForward.Enabled = true;
            btnBackward.Enabled = true;
            _encryption.Decrypt();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            _counter--;
            if(_counter <= 0)
            _counter = _encryption.LetterCount;
            tbKey.Text = _counter.ToString();
            _encryption = new Caesar(rtbInput.Text,_counter.ToString());
            rtbOutput.Text = _encryption.Decrypt();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            _counter++;
            if(_counter > _encryption.LetterCount)
            _counter = 0;
            tbKey.Text = _counter.ToString();
            _encryption = new Caesar(rtbInput.Text, _counter.ToString());
            rtbOutput.Text = _encryption.Decrypt();  
        }
    }
}
