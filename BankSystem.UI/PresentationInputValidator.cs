using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystemBusinessLayer;

namespace BankSystem
{
    public static class PresentationInputValidator
    {

        public static bool IsNumeric(string text)
        {
            return BuisnessInputValidator.IsTextNumeric(text);
        }

        public static bool IsString(string text)
        {
            return BuisnessInputValidator.IsTextString(text);
        }

        public static bool IsControlTextNull(string controlText)
        {
            return BuisnessInputValidator.IsEmpty(controlText);
        }

        public static void SetMessageError(TextBox control, string messageValue, ErrorProvider errorProvider)
        {
            errorProvider.SetError(control, messageValue);
        }

        public static bool IsObjectNull(object obj)
        {
            return BuisnessInputValidator.IsObjectNull(obj);
        }

        public static bool IsAccountNumberDuplicated(string accountNumber)
        {
            return BuisnessInputValidator.IsValueDuplicated(accountNumber);
        }
    }
}
