using System;
using System.Data;
using System.Runtime.CompilerServices;
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

        private Persons(string firstName, string lastName, string email)
        {
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

        private bool IsEmptyValidation()
        {
            if (BusinessInputValidator.IsEmpty(this.personID.ToString()) || BusinessInputValidator.IsEmpty(this.firstName) ||
                BusinessInputValidator.IsEmpty(this.lastName))
            {
                return true;
            }

            return false;
        }

        private bool IsNotNumericValidation()
        {
            return (!BusinessInputValidator.IsTextNumeric(this.personID.ToString()));        
        }

        private bool IsNotStringValidation()
        {
            return (!BusinessInputValidator.IsTextString(this.firstName) || !BusinessInputValidator.IsTextString(this.lastName));          
        }

        public bool Save()
        {
            if (IsEmptyValidation() || IsNotNumericValidation() || IsNotStringValidation())
                return false;
               
            switch (mode)
            {
                case enMode.AddNew:
                    if(AddNewPerson())
                    {
                        mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return UpdatePerson();
            }

            return false;
        }

        public static Persons Find(int personID)
        {
            string email = "", firstName = "", lastName = "";

            if (PersonsData.GetPersonInfoByPersonID(personID, ref firstName, ref lastName, ref email))
                return new Persons(firstName, lastName, email);

            else
                return null;
        }

        public static Persons Find(string firstName, string lastName)
        {
            int personID = -1;
            string email = "";

            if (PersonsData.GetPersonInfoByFirstNameAndLastName(firstName, ref personID, lastName, ref email))
                return new Persons(personID, firstName, lastName, email);

            else
                return null;
        }
        //public static void ResetPersonIdentity()
        //{
        //    if (!PersonsData.ResetPersonsIdentity())
        //        return;
        //}

        public static bool DeletePerson(int personID)
        {
            return PersonsData.DeletePerson(personID);
        }

        public bool UpdatePerson()
        {
            return PersonsData.UpdatePerson(this.personID, this.firstName, this.lastName, this.email);
        }
    }
}