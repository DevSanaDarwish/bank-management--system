using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankSystemBusinessLayer
{
    public static class clsInputValidator
    {
        public static bool IsTextNumeric(string text)
        {
            if(int.TryParse(text, out int number))
                return (number  >= 48 && number <= 57);

            return false;
        }

        public static bool IsTextEmpty(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return true;

            return false;
        }
    }
}
