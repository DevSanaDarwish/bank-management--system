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

        private bool AddNewPhone()
        {
            this.phoneID = PhonesData.AddNewPhone(this.phoneNumber, this.personID);

            return (this.phoneID != -1);
        }

        public bool Save()
        {
            switch(mode)
            {
                case enMode.AddNew:
                    if(AddNewPhone())
                    {
                        mode = enMode.Update;
                        return true;
                    }

                    return false;
            }

            return false;
        }


        public static Phones Find(int personID)
        {
            string phoneNumber = "";
            int phoneID = -1;

            if (PhonesData.GetPhoneInfoByPersonID(personID, ref phoneNumber, ref phoneID))
                return new Phones(phoneID, phoneNumber, personID);

            else
                return null;
        }
    }
}
