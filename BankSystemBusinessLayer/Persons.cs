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
        public enMode Mode = enMode.AddNew;

        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Persons()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";

            Mode = enMode.AddNew;
        }

        private Persons(int personID, string firstName, string lastName, string email)
        {
            this.PersonID = personID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;

            Mode = enMode.Update;
        }

        private Persons(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;

            Mode = enMode.Update;
        }

        private bool AddNewPerson()
        {
            this.PersonID = PersonsData.AddNewPerson(this.FirstName, this.LastName, this.Email);

            return (PersonID != -1);
        }

        private bool IsEmptyValidation()
        {
            if (BusinessInputValidator.IsEmpty(this.PersonID.ToString()) || BusinessInputValidator.IsEmpty(this.FirstName) ||
                BusinessInputValidator.IsEmpty(this.LastName))
            {
                return true;
            }

            return false;
        }

        private bool IsNotNumericValidation()
        {
            return (!BusinessInputValidator.IsTextNumeric(this.PersonID.ToString()));        
        }

        private bool IsNotStringValidation()
        {
            return (!BusinessInputValidator.IsTextString(this.FirstName) || !BusinessInputValidator.IsTextString(this.LastName));          
        }

        public bool Save()
        {
            if (IsEmptyValidation() || IsNotNumericValidation() || IsNotStringValidation())
                return false;
               
            switch (Mode)
            {
                case enMode.AddNew:
                    if(AddNewPerson())
                    {
                        Mode = enMode.Update;
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


        //مالا داعي
        public static bool DeletePerson(int personID)
        {
            return PersonsData.DeletePerson(personID);
        }

        public bool UpdatePerson()
        {
            return PersonsData.UpdatePerson(this.PersonID, this.FirstName, this.LastName, this.Email);
        }
    }
}