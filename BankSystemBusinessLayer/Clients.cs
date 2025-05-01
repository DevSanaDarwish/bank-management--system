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

        public int ClientID { get; set; }
        public string PinCode { get; set; }
        public decimal Balance { get; set; }
        public string AccountNumber { get; set; }
        public int PersonID { get; set; }

        public Clients()
        {
            this.ClientID = -1;
            this.PinCode = "";
            this.Balance = 0;
            this.AccountNumber = "";
            this.PersonID = -1;

            Mode = enMode.AddNew;
        }

        public Clients(int clientID, string pinCode, decimal balance, string accountNumber, int personID)
        {
            this.ClientID = clientID;
            this.PinCode = pinCode;
            this.Balance = balance;
            this.AccountNumber = accountNumber;
            this.PersonID = personID;

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
            this.ClientID = ClientsData.AddNewClient(this.PinCode, this.Balance, this.AccountNumber, this.PersonID);

            return (ClientID != -1);
        }

        private bool IsEmptyValidation()
        {
            if (BusinessInputValidator.IsEmpty(this.ClientID.ToString()) || BusinessInputValidator.IsEmpty(this.PinCode) || 
                BusinessInputValidator.IsEmpty(this.Balance.ToString()) || BusinessInputValidator.IsEmpty(this.AccountNumber) 
                || BusinessInputValidator.IsEmpty(this.PersonID.ToString()))
            {
                return true;
            }

            return false;
        }

        private bool IsNotNumericValidation()
        {
            if (!BusinessInputValidator.IsTextNumeric(this.ClientID.ToString()) || !BusinessInputValidator.IsTextNumeric(this.PinCode) ||
                !BusinessInputValidator.IsTextNumeric(this.PersonID.ToString()) || !BusinessInputValidator.IsTextNumeric(this.Balance.ToString()))
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
            return ClientsData.UpdateClient(this.AccountNumber, this.PinCode, this.Balance);
        }

        public static bool DepositAmount(decimal depositAmount, string accountNumber)
        {
            return ClientsData.DepositAmount(depositAmount, accountNumber);
        }

        public bool IsAmountValid(decimal amount)
        {
            return BusinessInputValidator.IsValueValid(amount, this.Balance);      
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
