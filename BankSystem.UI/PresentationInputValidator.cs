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
            return BusinessInputValidator.IsTextNumeric(text);
        }

        public static bool IsString(string text)
        {
            return BusinessInputValidator.IsTextString(text);
        }

        public static bool IsControlTextNull(string controlText)
        {
            return BusinessInputValidator.IsEmpty(controlText);
        }

        public static void SetMessageError(TextBox control, string messageValue, ErrorProvider errorProvider)
        {
            errorProvider.SetError(control, messageValue);
        }

        public static bool IsObjectNull(object obj)
        {
            return BusinessInputValidator.IsObjectNull(obj);
        }

        public static bool IsAccountNumberDuplicated(string accountNumber)
        {
            return BusinessInputValidator.IsValueDuplicated(accountNumber);
        }

        public static bool IsAmountPositive(decimal amount)
        {
            return BusinessInputValidator.IsValuePositive(amount);
        }

        public static bool IsAmountLessThanBalance(decimal amount, decimal balance)
        {
            return BusinessInputValidator.IsValueValid(amount, balance);
        }
    }
}
