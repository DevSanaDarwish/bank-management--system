using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BankSystemBusinessLayer
{
    public static class EncryptionPassword
    { 
        public static StringBuilder EncryptThePassword(string password, int key = 10)
        {
            StringBuilder sbEncryptPassword = new StringBuilder();

            if (string.IsNullOrEmpty(password))
                return sbEncryptPassword;

            for (byte i = 0; i < password.Length; i++)
            {
                sbEncryptPassword.Append((char)(password[i] + key));
            }

            return sbEncryptPassword;
        }

        //public static StringBuilder DecryptThePassword(string password, int key = 10)
        //{
        //    StringBuilder sbDecryptPassword = new StringBuilder();

        //    if (string.IsNullOrEmpty(password))
        //        return sbDecryptPassword;

        //    for (byte i = 0; i < password.Length; i++)
        //    {
        //        sbDecryptPassword.Append((char)(password[i] - key));
        //    }

        //    return sbDecryptPassword;
        //}


    }
}
