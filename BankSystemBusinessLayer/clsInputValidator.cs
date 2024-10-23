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
            for (int i = 0; i < text.Length; i++)
            {
              //if (text[i] <= 'A' || text[i] >= 'Z' || text[i] <= 'a' || text[i] >= 'z')
                if (!(text[i] >= 'A' && text[i] <= 'Z') && !(text[i] >= 'a' && text[i] <= 'z'))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsEmpty(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return true;

            return false;
        }      
    }
}