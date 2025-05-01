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

        public int UserID { get; set; }
        public string Username { get; set; }
        public int Permissions { get; set; }
        public string Password { get; set; }
        public int PersonID { get; set; }

        private static byte _trialCounter = 3, _minimumPasswordLength = 4, _maximumPasswordLength = 15;

        public Users()
        {
            this.UserID = -1;
            this.Username = "";
            this.Permissions = -1;
            this.Password = "";
            this.PersonID = -1;

            Mode = enMode.AddNew;
        }

        private Users(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
        private Users(int userID, string username, int permissions, string password, int personID)
        {
            this.UserID = userID;
            this.Username = username;
            this.Permissions = permissions;
            this.Password = password;
            this.PersonID = personID;

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
            if (BusinessInputValidator.IsEmpty(this.UserID.ToString()) || BusinessInputValidator.IsEmpty(this.Username) ||
                BusinessInputValidator.IsEmpty(this.Permissions.ToString()) || BusinessInputValidator.IsEmpty(this.Password)
                || BusinessInputValidator.IsEmpty(this.PersonID.ToString()))
            {
                return true;
            }

            return false;
        }

        private bool IsNotNumericValidation()
        {
            if (!BusinessInputValidator.IsTextNumeric(this.UserID.ToString()) || !BusinessInputValidator.IsTextNumeric(this.Permissions.ToString()) ||
                !BusinessInputValidator.IsTextNumeric(this.PersonID.ToString()))
            {
                return true;
            }

            return false;
        }

        private bool IsNotStringValidation()
        {
            return (!BusinessInputValidator.IsTextString(this.Username));
        }

        private bool AddNewUser()
        {
            this.UserID = UsersData.AddNewUser(this.Username, this.Permissions, this.Password, this.PersonID);

            return (UserID != -1);
        }

        public static bool DeleteUser(string username)
        {
            return UsersData.DeleteUser(username);
        }
        public bool UpdateUser()
        {
            return UsersData.UpdateUser(this.Username, this.Permissions, this.Password);
        }

        //public bool UpdateUser()
        //{

        //}

        public bool Save()
        {
            if (IsEmptyValidation() || IsNotNumericValidation() || IsNotStringValidation())
                return false;

            switch (Mode)
            {
                case enMode.AddNew:
                    if(AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;                        
                    }

                    return false;

               // case enMode.Update:
                    //return UpdateUser();
            }

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
