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
    }
}
