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

        public Phones(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;

            mode = enMode.Update;
        }

        private bool AddNewPhone()
        {
            this.phoneID = PhonesData.AddNewPhone(this.phoneNumber, this.personID);

            return (this.phoneID != -1);
        }

        private bool IsEmptyValidation()
        {
            if (clsInputValidator.IsEmpty(this.phoneID.ToString()) || clsInputValidator.IsEmpty(this.personID.ToString()) ||
                clsInputValidator.IsEmpty(this.phoneNumber))
            { 
                return true;
            }

            return false;
        }

        private bool IsNotNumericValidation()
        {
            if (!clsInputValidator.IsTextNumeric(this.phoneID.ToString()) || !clsInputValidator.IsTextNumeric(this.personID.ToString())
                || !clsInputValidator.IsTextNumeric(this.phoneNumber))
            {
                return true;
            }

            return false;
        }

        public bool Save()
        {
            if (IsEmptyValidation() || IsNotNumericValidation())
                return false;

            switch (mode)
            {
                case enMode.AddNew:
                    if(AddNewPhone())
                    {
                        mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return UpdatePhone();
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

        //public static void ResetPhonesIdentity()
        //{
        //    if (!PhonesData.ResetPhonesIdentity())
        //        return;
        //}

        public static bool DeletePhone(int personID)
        {
            return PhonesData.DeletePhone(personID);
        }

        public bool UpdatePhone()
        {
            return PhonesData.UpdatePhone(this.personID, this.phoneNumber);
        }
    }
}
