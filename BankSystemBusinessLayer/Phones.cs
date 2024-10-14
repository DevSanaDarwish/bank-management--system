using System;
using System.Data;
using BankSystemDataAccessLayer;

namespace BankSystemBusinessLayer
{
    public class Phones
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode mode = enMode.AddNew;

        public int phoneID { get; set; }

        public string phoneNumber { get; set; }

        public int personID { get; set; }

        public Phones()
        {
            this.phoneID = -1;
            this.phoneNumber = "";
            this.personID = -1;

            mode = enMode.AddNew;
        }

        public Phones(int phoneID, string phoneNumber, int personID)
        {
            this.phoneID = phoneID;
            this.phoneNumber = phoneNumber;
            this.personID = personID;

            mode = enMode.Update;
        }
    }
}
