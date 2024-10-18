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


        public bool Save()
        {
            if (clsInputValidator.IsEmpty(this.clientID.ToString()) || clsInputValidator.IsEmpty(this.pinCode) || clsInputValidator.IsEmpty(this.balance.ToString()) ||
                clsInputValidator.IsEmpty(this.accountNumber.ToString()) || clsInputValidator.IsEmpty(this.personID.ToString()))
            {
                return false;
            }
                
            switch (mode)
            {
                case enMode.AddNew:
                    if (AddNewClient())
                    {
                        mode = enMode.Update;
                        return true;
                    }

                    return false;
            }

            return false;
        }


        public static Clients Find(string firstName)
        {
            int clientID = -1, personID = -1;
            string pinCode = "", accountNumber = "",  lastName = "", email = "", phoneNumber = "";
            decimal balance = 0;

            if (ClientsData.GetClientInfoByFirstName(firstName, ref lastName, ref email, ref phoneNumber, ref pinCode, ref balance, ref accountNumber))
                return new Clients(clientID, pinCode, balance, accountNumber, personID);

            else
                return null;
        }

        public static void ResetClientIdentity()
        {
            if (!ClientsData.ResetClientIdentity())
                return;
        }
    }
}
