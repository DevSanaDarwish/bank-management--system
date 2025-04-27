using System;
using System.Data;
using System.Runtime.CompilerServices;
using BankSystemDataAccessLayer;

namespace BankSystemBusinessLayer
{
    public class Clients
    {
        public enum enMode { AddNew = 1, Update = 2};
        public enMode Mode = enMode.AddNew;

        public int clientID { get; set; }
        public string pinCode { get; set; }
        public decimal balance { get; set; }
        public string accountNumber { get; set; }
        public int personID { get; set; }

        public Clients()
        {
            this.clientID = -1;
            this.pinCode = "";
            this.balance = 0;
            this.accountNumber = "";
            this.personID = -1;

            Mode = enMode.AddNew;
        }

        public Clients(int clientID, string pinCode, decimal balance, string accountNumber, int personID)
        {
            this.clientID = clientID;
            this.pinCode = pinCode;
            this.balance = balance;
            this.accountNumber = accountNumber;
            this.personID = personID;

            Mode = enMode.Update;
        }


        public static DataTable GetAllClients()
        {
            return ClientsData.GetAllClients();
        }

        public static DataTable GetTotalBalances()
        {
            return ClientsData.GetTotalBalances();
        }

        private bool AddNewClient()
        {
            this.clientID = ClientsData.AddNewClient(this.pinCode, this.balance, this.accountNumber, this.personID);

            return (clientID != -1);
        }

        private bool IsEmptyValidation()
        {
            if (BusinessInputValidator.IsEmpty(this.clientID.ToString()) || BusinessInputValidator.IsEmpty(this.pinCode) || 
                BusinessInputValidator.IsEmpty(this.balance.ToString()) || BusinessInputValidator.IsEmpty(this.accountNumber) 
                || BusinessInputValidator.IsEmpty(this.personID.ToString()))
            {
                return true;
            }

            return false;
        }

        private bool IsNotNumericValidation()
        {
            if (!BusinessInputValidator.IsTextNumeric(this.clientID.ToString()) || !BusinessInputValidator.IsTextNumeric(this.pinCode) ||
                !BusinessInputValidator.IsTextNumeric(this.personID.ToString()) || !BusinessInputValidator.IsTextNumeric(this.balance.ToString()))
            {
                return true;
            }

            return false;
        }

        public bool Save()
        {
            if (IsEmptyValidation() || IsNotNumericValidation())
                return false;

            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewClient())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return UpdateClient();
            }

            return false;
        }

        public static Clients FindByAccountNumber(string accountNumber)
        {
            string pinCode = "";
            decimal balance = 0;
            int personID = -1, clientID = -1;

            if (ClientsData.GetClientInfoByAccountNumber(accountNumber, ref pinCode, ref balance, ref personID, ref clientID))
                return new Clients(clientID, pinCode, balance, accountNumber, personID);

            else
                return null;
        }

        //public static void ResetClientIdentity()
        //{
        //    if (!ClientsData.ResetClientIdentity())
        //        return;
        //}

        public static bool DeleteClient(string accountNumber)
        {
            return (ClientsData.DeleteClient(accountNumber));
        }

        public bool UpdateClient()
        {
            return ClientsData.UpdateClient(this.accountNumber, this.pinCode, this.balance);
        }

        public static bool DepositAmount(decimal depositAmount, string accountNumber)
        {
            return ClientsData.DepositAmount(depositAmount, accountNumber);
        }

        public bool IsAmountValid(decimal amount)
        {
            return BusinessInputValidator.IsValueValid(amount, this.balance);      
        }

        public bool IsAmountPositive(decimal amount)
        {
            return BusinessInputValidator.IsValuePositive(amount);
        }

        public bool WithdrawAmount(decimal withdrawAmount, string accountNumber)
        {
            if(IsAmountValid(withdrawAmount))
            {
                return ClientsData.WithdrawAmount(withdrawAmount, accountNumber);
            }

            return false;
        }

        public bool TransferAmount(string accountNumberFrom, string accountNumberTo, decimal amount)
        {
            if (IsAmountValid(amount))
            {
                return ClientsData.TransferAmount(accountNumberFrom, accountNumberTo, amount);
            }

            return false;
        }

        public static bool IsAccountNumberExist(string accountNumber)
        {
            return ClientsData.IsAccountNumberExist(accountNumber);
        }

        public static decimal GetSumOfBalances()
        {
            return ClientsData.GetSumOfBalances();
        }

       
    }
}
