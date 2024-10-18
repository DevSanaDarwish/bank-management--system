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

        public static bool IsNumeric(string input)
        {
            return clsInputValidator.IsTextNumeric(input);
        }

        public static bool IsControlTextNull(string controlText)
        {
            return clsInputValidator.IsTextEmpty(controlText);
        }

        public static void SetError(TextBox control, string messageValue, ErrorProvider errorProvider, ref bool isValidTextBoxes, bool isValid = false)
        {
            errorProvider.SetError(control, messageValue);

            isValidTextBoxes = isValid;
        }
    }
}
