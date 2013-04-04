using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Encryption
{
    public class DES : Encryption
    {
        public DES(string input, string key)
            : base(input, key)
        {
        }

        public string IV;
        public new string Key;

        public void Encrypt(string saveEncFile, string openKeyFile, string txtFilePath)
        {
            var fsInput = new FileStream(txtFilePath, FileMode.Open, FileAccess.Read);
            var fsKey = new FileStream(openKeyFile, FileMode.Open, FileAccess.Read);
            var fsEncrypted = new FileStream(saveEncFile, FileMode.Create, FileAccess.Write);
            var sr = new StreamReader(fsKey);
            var sKey = sr.ReadToEnd();
            var des = new DESCryptoServiceProvider();
            des.Key = Encoding.ASCII.GetBytes(sKey);
            des.IV = Encoding.ASCII.GetBytes(sKey);
            var desencrypt = des.CreateEncryptor();
            var cryptostream = new CryptoStream(fsEncrypted, desencrypt, CryptoStreamMode.Write);
            var bytearrayinput = new byte[fsInput.Length - 1];
            fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Close();
            fsInput.Close();
            fsEncrypted.Close();
        }

        public void Decrypt(string saveDecFile, string openKeyFile, string txtFilePath)
        {
            var des = new DESCryptoServiceProvider();
            var fsKey = new FileStream(openKeyFile, FileMode.Open, FileAccess.Read);
            var sr = new StreamReader(fsKey);
            var sKey = sr.ReadToEnd();
            des.Key = Encoding.ASCII.GetBytes(sKey);
            des.IV = Encoding.ASCII.GetBytes(sKey);
            var fsread = new FileStream(txtFilePath, FileMode.Open, FileAccess.Read);
            var desdecrypt = des.CreateDecryptor();
            var cryptostreamDecr = new CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read);
            var fsDecrypted = new StreamWriter(saveDecFile);
            fsDecrypted.Write(new StreamReader(cryptostreamDecr).ReadToEnd());
            fsDecrypted.Flush();
            fsDecrypted.Close();
        }
        public static string GenerateKey()
        {
            var desCrypto = (DESCryptoServiceProvider)System.Security.Cryptography.DES.Create();
            return Encoding.ASCII.GetString(desCrypto.Key);
        }
    }
}
