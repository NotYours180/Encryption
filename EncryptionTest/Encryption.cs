using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ELW.Library.Math;
using ELW.Library.Math.Exceptions;
using ELW.Library.Math.Expressions;

namespace Encryption
{
    public class Encryption
    {
        public string Input;
        public char[] ArrInput;
        public byte[] BArrInput;
        public virtual string Key { get; set; }

        public char[] ChrKey;
        public int[] IntKey;
        public Language InputLang;
        public string InputUri;
        public Language KeyLang;
        public int LetterCount;
        protected CompiledExpression CompiledExpression;

        public enum Language
        { 
            Russian,
            English,
            Different,
            Undefined
        }

        public Encryption(string input, string key)
        { 
            Input = input;
            BArrInput = Encoding.UTF8.GetBytes(input);
            ArrInput = input.ToArray();
            InputLang = GetLanguage(ArrInput);
            if (key != null)
            {
                Key = key;
                //KeyLang = GetLanguage(ChrKey);
                ChrKey = key.ToArray();
            }

            switch(InputLang)
            {
                case Language.English: LetterCount=26;
                    break;
                case Language.Russian: LetterCount=33;
                    break;
            }
        }

        public virtual string Encrypt()
        {
            throw new NotImplementedException();
        }

        public virtual string Decrypt()
        {
            throw new NotImplementedException();
        }

        public static Language GetLanguage(IEnumerable<char> input)
        {
            var lang = Language.Undefined;
            foreach (char t in input)
            {
                int index = t;
                if ((index >= 'А' && index <= 'я') || index == 'ё')
                {
                    lang = CheckDifferency(Language.Russian, lang);
                }
                else if ((index >= 'A' && index <= 'Z') || (index >= 'a' && index <= 'z'))
                {
                    lang = CheckDifferency(Language.English, lang);
                }
            }
            return lang;
        }

        public static int GetCharIndex(Language lang, int l)
        {
            switch (lang)
            {
                case Language.English:
                    l += l < 0 ? 26 : 0;
                    return l + 96;
                case Language.Russian: 
                    l += l < 0 ? 33 : 0;
                    return l + (l == 7 ? 1098 : l > 7 ? 1070 : 1071);
                default: throw new InvalidDataException("Ошибка. Одна или несколько букв заданы неверно.");
            }
        }

        public static int GetLetterIndex(Language lang, char c)
        {
            switch (lang)
            {
                case Language.English:
                    return c - (char.IsUpper(c) ? 64 : 96);
                case Language.Russian:
                    return c - (char.IsUpper(c) ? c == 'Ё' ? 1018 : c > 'Е' ? 1038 : 1039 : c == 'ё' ? 1098 : c > 'е' ? 1070 : 1071); 
                default: throw new InvalidDataException("Ошибка. Одна или несколько букв заданы неверно.");
            }
        }

        protected CompiledExpression СompileExpression()
        {
            try
            {
                PreparedExpression preparedExpression = ToolsHelper.Parser.Parse(Key);
                CompiledExpression = ToolsHelper.Compiler.Compile(preparedExpression);
            }
            catch (CompilerSyntaxException ex)
            {
                MessageBox.Show(String.Format("Синтаксическая ошибка: {0}", ex.Message));
            }
            catch (MathProcessorException ex)
            {
                MessageBox.Show(String.Format("Ошибка: {0}", ex.Message));
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Ошибка ввода данных.");
            }
            catch (Exception)
            {
                MessageBox.Show("Непредвиденная ошибка.");
                throw;
            }
            return CompiledExpression;
        }

        private static Language CheckDifferency(Language l, Language lang)
        {
            if (lang == l) { return l; }
            return lang == Language.Undefined ? l : Language.Different;
        }
    }
}
