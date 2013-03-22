using System;
using ELW.Library.Math;
using ELW.Library.Math.Tools;

namespace Encryption
{
    class Tritemius : Encryption
    {
        private readonly OffsetType _encryptionType;

        public Tritemius(string input, string key, OffsetType type) : base(input, key)
        {
            _encryptionType = type;
            if (type == OffsetType.Expression)
            {
                CompiledExpression = СompileExpression();
            }
        }

        public enum OffsetType
        {
            Slogan,
            Expression
        }

        private int GetOffset(int index)
        {
            switch (_encryptionType)
            {
                case OffsetType.Expression:
                    return (int)ToolsHelper.Calculator.Calculate(CompiledExpression, new VariableValue(index, "x"));
                case OffsetType.Slogan:
                    return GetLetterIndex(KeyLang, ChrKey[index % ChrKey.Length]);
                default: throw new NotImplementedException("Не определен тип нахождения шага смещения");
            }
        }

        public override string Encrypt()
        {
            string res="";
            for(int i=0;i<ArrInput.Length;i++)
            {
                res += Convert.ToChar(GetCharIndex(InputLang, (GetLetterIndex(InputLang, ArrInput[i]) + GetOffset(i)) % LetterCount));
            }
            return res;
        }

        public override string Decrypt()
        {
            string res="";
            for(int i=0;i<ArrInput.Length;i++)
            {
                res += Convert.ToChar(GetCharIndex(InputLang, (GetLetterIndex(InputLang, ArrInput[i]) - GetOffset(i)) % LetterCount));
            }
            return res;
        }
    }
}
