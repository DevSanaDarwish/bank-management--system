using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystemBusinessLayer;

namespace BankSystem
{
    public static class InputValidator
    {

        public static bool IsNumeric(string text)
        {
            return clsInputValidator.IsTextNumeric(text);
        }

        public static bool IsString(string text)
        {
            return clsInputValidator.IsTextString(text);
        }

        public static bool IsControlTextNull(string controlText)
        {
            return clsInputValidator.IsEmpty(controlText);
        }

        public static void SetMessageError(TextBox control, string messageValue, ErrorProvider errorProvider)
        {
            errorProvider.SetError(control, messageValue);
        }

        public static bool IsObjectNull(object obj)
        {
            return clsInputValidator.IsObjectNull(obj);
        }
    }
}
