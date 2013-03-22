using System;

namespace Encryption
{
    class Gamma : Encryption
    {
        public Gamma(string input, string key)
            : base(input, key)
        {
            IntKey = new int[Input.Length];
        }

        public override string Encrypt()
        {
            var r = new Random();
            var res = ""; Key = "";
            for (int i = 0; i < Input.Length; i++)
            {
                Key += (IntKey[i] = r.Next(LetterCount) + 1) + " ";
                res += Convert.ToChar(GetCharIndex(InputLang, (GetLetterIndex(InputLang, ArrInput[i]) + IntKey[i]) % LetterCount));
            }
            return res;
        }

        public override string Decrypt()
        {
            var arr = Key.Split(' ');
            for (var i = 0; i < arr.Length-1; i++)
            {
                IntKey[i] = Convert.ToInt32(arr[i]);
            }  
            var res = "";
            for (var i = 0; i < Input.Length; i++)
            {
                res += Convert.ToChar(GetCharIndex(InputLang, (GetLetterIndex(InputLang, ArrInput[i]) - IntKey[i]) % LetterCount));
            }
            return res;
        }
    }
}
