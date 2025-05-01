using System;
using System.Collections.Generic;
using System.Data;
using BankSystemDataAccessLayer;

namespace BankSystemBusinessLayer
{
    public class Phones
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PhoneID { get; set; }

        public string PhoneNumber { get; set; }

        public int PersonID { get; set; }

        List<string> phoneNumbers { get; set; }

        List<int> phoneIds { get; set; }


        public Phones()
        {
            this.PhoneID = -1;
            this.PhoneNumber = "";
            this.PersonID = -1;
            this.phoneNumbers = new List<string>();
            this.phoneIds = new List<int>();

            Mode = enMode.AddNew;
        }

        public Phones(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;

            Mode = enMode.Update;
        }

        public Phones(string phoneNumber, int phoneID)
        {
            this.PhoneNumber = phoneNumber;
            this.PhoneID = phoneID;

            Mode = enMode.Update;
        }

        private bool AddNewPhone()
        {
            this.PhoneID = PhonesData.AddNewPhone(this.PhoneNumber, this.PersonID);

            return (this.PhoneID != -1);
        }

        private bool IsEmptyValidation()
        {
            if (BusinessInputValidator.IsEmpty(this.PhoneID.ToString()) || BusinessInputValidator.IsEmpty(this.PersonID.ToString()) ||
                BusinessInputValidator.IsEmpty(this.PhoneNumber))
            { 
                return true;
            }

            return false;
        }

        private bool IsNotNumericValidation()
        {
            if (!BusinessInputValidator.IsTextNumeric(this.PhoneID.ToString()) || !BusinessInputValidator.IsTextNumeric(this.PersonID.ToString())
                || !BusinessInputValidator.IsTextNumeric(this.PhoneNumber))
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
                    if(AddNewPhone())
                    {
                        //Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return UpdatePhone();
            }

            return false;
        }

        public bool Save(string phoneItem)
        {
            if (IsEmptyValidation() || IsNotNumericValidation())
                return false;

            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewPhone())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return UpdatePhone(phoneItem);
            }

            return false;
        }

        public static Phones Find(int clientID)
        {
            string phoneNumber = "";

            if (PhonesData.GetPhoneNumberByClientID(clientID, ref phoneNumber))
                return new Phones(phoneNumber);

            else
                return null;
        }

        public static List<int> GetPhoneIDs(int clientID)
        {
            List<string> phoneNumbers = new List<string>();

            List<int> phoneIds = new List<int>();

            if (PhonesData.GetPhoneNumberByClientIDInList(clientID, phoneNumbers, phoneIds))
            {
                return phoneIds;
            }

            return new List<int>();
        }

        public static List<Phones> FindInList(int clientID)
        {
            List<string> phoneNumbers = new List<string>();

            List<int> phoneIds = new List<int>();

            List<Phones> lstPhones = new List<Phones>();

            if(PhonesData.GetPhoneNumberByClientIDInList(clientID, phoneNumbers, phoneIds))
            {
                for(byte i = 0; i < phoneNumbers.Count; i++)
                {
                    Phones phone = new Phones(phoneNumbers[i], phoneIds[i]);

                    lstPhones.Add(phone);
                }     
            }

            return lstPhones;
        }

        

        //public static void ResetPhonesIdentity()
        //{
        //    if (!PhonesData.ResetPhonesIdentity())
        //        return;
        //}

        public static bool DeletePhone(int personID)
        {
            return PhonesData.DeletePhone(personID);
        }

        public static bool DeletePhoneByPhoneNumber(string phoneNumber)
        {
            return PhonesData.DeletePhoneByPhoneNumber(phoneNumber);
        }

        public bool UpdatePhone()
        {
            return PhonesData.UpdatePhone(this.PhoneID, this.PhoneNumber);
        }

        public bool UpdatePhone(string phoneItem)
        {
            return PhonesData.UpdatePhone(this.PhoneID, phoneItem);
        }

        public static byte GetCountOfPhonesNumbers(int personID)
        {
            return PhonesData.GetCountOfPhonesNumbers(personID);
        }

        public static bool IsPhoneExistByPhoneNumber(string phoneNumber)
        {
            return PhonesData.IsPhoneExistByPhoneNumber(phoneNumber);
        }
    }
}
