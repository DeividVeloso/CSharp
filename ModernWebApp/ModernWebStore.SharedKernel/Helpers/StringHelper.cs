using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernWebStore.SharedKernel.Helpers
{
    public class StringHelper
    {

        public static string Encrypt(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                var password = String.Empty;
                password = (value += "|2d331cca-f6c0-40c0-bb43-6e32989c2881");
                System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
                byte[] data = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(password));
                System.Text.StringBuilder sbString = new System.Text.StringBuilder();
                for (int i = 0; i < data.Length; i++)
                    sbString.Append(data[i].ToString("x2"));

                return sbString.ToString();
            }

            return "";
        }
    }
}

