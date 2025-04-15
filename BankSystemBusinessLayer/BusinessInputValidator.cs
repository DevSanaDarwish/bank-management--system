using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace BankSystemBusinessLayer
{
    public static class BusinessInputValidator
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

        public static bool IsObjectNull(object obj)
        {
            return (obj == null);
        }

        public static bool IsAccNumValueDuplicated(string value)
        {
            return Clients.IsAccountNumberExist(value);
        }

        public static bool IsPhoneNumberValueDuplicated(string value)
        {
            return Phones.IsPhoneExistByPhoneNumber(value);
        }

        public static bool IsValueZero(decimal value)
        {
            return value == 0;
        }

        public static bool IsValueValid(decimal amount, decimal balance)
        {
            return (amount <= balance);
        }

        public static bool IsValuePositive(decimal amount)
        {
            return amount > 0;
        }

        public static bool IsDifferentStringValues(string value1, string value2)
        {
            return !string.Equals(value1, value2, StringComparison.OrdinalIgnoreCase);
        }

        public static bool IsAmountValueValid(decimal amount, decimal maxAmount, decimal minAmount)
        {
            return (amount <= maxAmount && amount >= minAmount);
        }
    }
}