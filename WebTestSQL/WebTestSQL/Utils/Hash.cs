using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace WebTestSQL.Utils
{
    public class Hash
    {
        public static string GerarHash(string text)
        {
            SHA256 shaCrypt = SHA256Managed.Create();
            byte[] byteArray = Encoding.UTF8.GetBytes(text);
            byte[] hashArray = shaCrypt.ComputeHash(byteArray);
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < hashArray.Length; i++) { result.Append(hashArray[i].ToString("X")); }

            return result.ToString();
        }
    }
}