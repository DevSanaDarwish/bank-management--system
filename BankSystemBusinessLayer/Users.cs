using System;
using System.Data;
using System.Runtime.CompilerServices;
using BankSystemDataAccessLayer;

namespace BankSystemBusinessLayer
{
    public class Users
    {
        public enum enMode { AddNew = 1, Update = 2};
        public enMode Mode = enMode.AddNew;

        public int userID { get; set; }
        public string username { get; set; }
        public int permissions { get; set; }
        public string password { get; set; }
        public int personID { get; set; }

        private static byte _trialCounter = 3, _minimumPasswordLength = 4, _maximumPasswordLength = 15;

        public Users()
        {
            this.userID = -1;
            this.username = "";
            this.permissions = -1;
            this.password = "";
            this.personID = -1;

            Mode = enMode.AddNew;
        }

        private Users(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        private Users(int userID, string username, int permissions, string password, int personID)
        {
            this.userID = userID;
            this.username = username;
            this.permissions = permissions;
            this.password = password;
            this.personID = personID;

            Mode = enMode.Update;
        }

        public static DataTable GetAllUsers()
        {
            return UsersData.GetAllUsers();
        }

        public static Users Find(string username, string password)
        {
            if (UsersData.GetUsernameAndPassword(username, password))
                return new Users(username, password);

            else
                return null;
        }

        public static int GetUserIDByUsername(string username)
        {
            return UsersData.GetUserIDByUsername(username);
        }

        private bool IsEmptyValidation()
        {
            if (BusinessInputValidator.IsEmpty(this.userID.ToString()) || BusinessInputValidator.IsEmpty(this.username) ||
                BusinessInputValidator.IsEmpty(this.permissions.ToString()) || BusinessInputValidator.IsEmpty(this.password)
                || BusinessInputValidator.IsEmpty(this.personID.ToString()))
            {
                return true;
            }

            return false;
        }

        private bool IsNotNumericValidation()
        {
            if (!BusinessInputValidator.IsTextNumeric(this.userID.ToString()) || !BusinessInputValidator.IsTextNumeric(this.permissions.ToString()) ||
                !BusinessInputValidator.IsTextNumeric(this.personID.ToString()))
            {
                return true;
            }

            return false;
        }

        private bool IsNotStringValidation()
        {
            return (!BusinessInputValidator.IsTextString(this.username));
        }

        public bool Save()
        {
            if (IsEmptyValidation() || IsNotNumericValidation() || IsNotStringValidation())
                return false;


        }

        public static bool IsUsernameExist(string username)
        {
            return UsersData.IsUsernameExist(username);
        }

        public static byte GetRemainingTrials()
        {
            return _trialCounter;
        }

        public static void DecrementTrialCounter()
        {
            if (_trialCounter > 0)
                --_trialCounter;
        }
        
        public static bool IsLockedOut()
        {
            return (_trialCounter == 0);
        }

        public static void ResetTrialCounter()
        {
            _trialCounter = 3;
        }

        public static byte GetMinimumPasswordLength()
        {
            return _minimumPasswordLength;
        }

        public static byte GetMaximumPasswordLength()
        {
            return _maximumPasswordLength;
        }

        public static bool IsValidPasswordLength(byte passwordLength)
        {
            if (passwordLength == 0)
                return false;

            return (passwordLength >= _minimumPasswordLength && passwordLength <= _maximumPasswordLength);
        }

    }
}
