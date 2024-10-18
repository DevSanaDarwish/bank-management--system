using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public static class InputValidator
    {
        static bool _isValidTextBoxes = false;

        public static bool IsNumeric(string input)
        {
            return input.All(char.IsDigit);
        }

        public static bool IsControlTextNull(string controlText)
        {
            if (string.IsNullOrWhiteSpace(controlText))
                return true;

            return false;
        }

        public static void SetError(TextBox control, string messageValue, bool isValid = false, ErrorProvider errorProvider)
        {
            errorProvider.SetError(control, messageValue);

            _isValidTextBoxes = isValid;
        }
    }
}
