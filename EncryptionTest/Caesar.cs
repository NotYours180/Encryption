using System;

namespace Encryption
{
    class Caesar : Encryption
    {
        private string _outputText;

        public Caesar(string input, string key) : base(input, key) { }

        public override string Encrypt()
        {
            _outputText = ""; 
            foreach (char t in ArrInput)
            {
                _outputText += Convert.ToChar(Convert.ToInt32(t) + Convert.ToInt32(Key));
            }
            return _outputText;
        }

        public override string Decrypt()
        {
            _outputText = "";
            foreach (char t in ArrInput)
            {
                int index = Convert.ToInt32(t - Convert.ToInt32(Key));
                if(char.IsLower(t))
                {
                    //if(index < LeftLimitLc)
                    //{ index += LetterCount;}
                }
                if(char.IsUpper(t))
                {
                    //if(index < LeftLimitUc)
                    //{ index += LetterCount;}
                }
                _outputText += Convert.ToChar(index);
            }
            return _outputText;
        }
    }
}
