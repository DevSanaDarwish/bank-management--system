using System;
using System.Data;
using BankSystemDataAccessLayer;

namespace BankSystemBusinessLayer
{
    public class Clients
    {
        public enum enMode { AddNew = 1, Update = 2};
        public enMode mode = enMode.AddNew;

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

            mode = enMode.AddNew;
        }

        public Clients(int clientID, string pinCode, decimal balance, string accountNumber, int personID)
        {
            this.clientID = clientID;
            this.pinCode = pinCode;
            this.balance = balance;
            this.accountNumber = accountNumber;
            this.personID = personID;

            mode = enMode.Update;
        }


        public static DataTable GetAllClients()
        {
            return ClientsData.GetAllClients();
        }

        private bool AddNewClient()
        {
            this.clientID = ClientsData.AddNewClient(this.pinCode, this.balance, this.accountNumber, this.personID);

            return (clientID != -1);
        }

        private bool IsEmptyValidation()
        {
            if (clsInputValidator.IsEmpty(this.clientID.ToString()) || clsInputValidator.IsEmpty(this.pinCode) || clsInputValidator.IsEmpty(this.balance.ToString()) ||
                clsInputValidator.IsEmpty(this.accountNumber) || clsInputValidator.IsEmpty(this.personID.ToString()))
            {
                return true;
            }

            return false;
        }

        private bool IsNotNumericValidation()
        {
            if (!clsInputValidator.IsTextNumeric(this.clientID.ToString()) || !clsInputValidator.IsTextNumeric(this.pinCode) ||
                !clsInputValidator.IsTextNumeric(this.personID.ToString()) || !clsInputValidator.IsTextNumeric(this.balance.ToString()))
            {
                return true;
            }

            return false;
        }
        public bool Save()
        {
            if (IsEmptyValidation())
                return false;

            if (IsNotNumericValidation())
                return false;

            switch (mode)
            {
                case enMode.AddNew:
                    if (AddNewClient())
                    {
                        mode = enMode.Update;
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

        public static void ResetClientIdentity()
        {
            if (!ClientsData.ResetClientIdentity())
                return;
        }

        public static bool DeleteClient(string accountNumber)
        {
            return (ClientsData.DeleteClient(accountNumber));
        }

        public bool UpdateClient()
        {
            return ClientsData.UpdateClient(this.accountNumber, this.pinCode, this.balance);
        }
    }
}
