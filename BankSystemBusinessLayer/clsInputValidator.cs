using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace BankSystemBusinessLayer
{
    public static class clsInputValidator
    {
        public static bool IsTextNumeric(string text)
        {
            return (decimal.TryParse(text, out _));       
        }

        public static bool IsTextString(string text)
        {
            return !IsTextNumeric(text);

            //return ((Convert.ToInt32(text) >= 65 && Convert.ToInt32(text) <= 90) || (Convert.ToInt32(text) >= 97 && Convert.ToInt32(text) <= 122));
        }

        public static bool IsEmpty(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return true;

            return false;
        }      
    }
}