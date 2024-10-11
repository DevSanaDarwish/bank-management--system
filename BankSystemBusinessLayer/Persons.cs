using System;
using System.Data;
using BankSystemDataAccessLayer;

namespace BankSystemBusinessLayer
{
    public class Persons
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode mode = enMode.AddNew;

        public int personID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }

        public Persons()
        {
            this.personID = -1;
            this.firstName = "";
            this.lastName = "";
            this.email = "";

            mode = enMode.AddNew;
        }

        private Persons(int personID, string firstName, string lastName, string email)
        {
            this.personID = personID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;

            mode = enMode.Update;
        }
    }
}
