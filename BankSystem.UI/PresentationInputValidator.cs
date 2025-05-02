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
            return BusinessInputValidator.IsAccNumValueDuplicated(accountNumber);
        }

        public static bool IsUsernameDuplicated(string username)
        {
            return BusinessInputValidator.IsUsernameDuplicated(username);
        }

        public static bool IsPhoneNumberValueDuplicated(string phoneNumber)
        {
            return BusinessInputValidator.IsPhoneNumberValueDuplicated(phoneNumber);
        }
        public static bool IsAmountPositive(decimal amount)
        {
            return BusinessInputValidator.IsValuePositive(amount);
        }

        public static bool IsAmountLessThanBalance(decimal amount, decimal balance)
        {
            return BusinessInputValidator.IsValueValid(amount, balance);
        }

        public static bool IsDifferentAccountsNumber(string value1, string value2)
        {
            return BusinessInputValidator.IsDifferentStringValues(value1, value2);
        }

        public static bool ValidationValue(decimal value, decimal maxValue, decimal minValue)
        {
            return BusinessInputValidator.ValidationValue(value, maxValue, minValue);
        }


        public static bool IsBalanceZero(decimal balance)
        {
            return BusinessInputValidator.IsValueZero(balance);
        }


    }
}
