using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace VKTIM.Common
{
    public class Crytopo
    {
        //Variables
        static readonly string PasswordHash = "p@@sW0RD";
        static readonly string SaltKey = "S@MO&KEY";
        static readonly string VIKey = "@1A5k9D4f5K6g2K1";

        /// <summary>
        /// MD5 Hash
        /// </summary>
        /// <param name="strNeedEncrypted"></param>
        /// <returns></returns>
        public static string MD5_Hash(string strNeedEncrypted)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            //Compute hash from the byte of text input
            md5.ComputeHash(Encoding.UTF8.GetBytes(strNeedEncrypted));

            //Get hash result after compute it
            byte[] result = md5.Hash;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++ )
            {
                //Change it into 2 hexadecimal digits
                //foreach byte
                sb.Append(result[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public static string Encrypt_Rfc2898(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

            byte[] cipherTextBytes;

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }
            return Convert.ToBase64String(cipherTextBytes);
        }

        public static string Decrypt_Rfc2898(string encryptedText)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }
    }
}
