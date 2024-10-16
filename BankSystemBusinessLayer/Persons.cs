using System;
using System.Data;
using System.Runtime.InteropServices;
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

        private bool AddNewPerson()
        {
            this.personID = PersonsData.AddNewPerson(this.firstName, this.lastName, this.email);

            return (personID != -1);
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.AddNew:
                    if(AddNewPerson())
                    {
                        mode = enMode.Update;
                        return true;
                    }

                    return false;
            }

            return false;
        }

        public static Persons Find(string firstName)
        {
            int personID = -1;
            string lastName = "", email = "";

            if (PersonsData.GetPersonInfoByFirstName(firstName, ref personID, ref lastName, ref email))
                return new Persons(personID, firstName, lastName, email);

            else
                return null;
        }
    }
}