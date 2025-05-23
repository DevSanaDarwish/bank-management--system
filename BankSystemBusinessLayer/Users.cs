﻿using System;
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
        public short Permissions { get; set; }
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

        private Users(int userID, string username, short permissions, string password, int personID)
        {
            this.UserID = userID;
            this.Username = username;
            this.Permissions = permissions;
            this.Password = password;
            this.PersonID = personID;

            Mode = enMode.Update;
        }

        public static Users FindByUsername(string username)
        {
            string password = "";
            short permissions = -1;
            int personsID = -1, userID = -1;

            if (UsersData.GetUserInfoByUsername(username, ref permissions, ref password, ref personsID, ref userID))
                return new Users(userID, username, permissions, password, personsID);

            else
                return null;
        }

        public bool CheckAccessPermission(PermissionsEnum.enPermissions selectedPermission)
        {
            if (this.Permissions == (short)PermissionsEnum.enPermissions.All)
                return true;

            if (((short)selectedPermission & this.Permissions) == (short)selectedPermission)
                return true;

            return false;
        }       

        public static DataTable GetAllUsers()
        {
            return UsersData.GetAllUsers();
        }

        public static string EncryptInputPassword(string originalPassword)
        {
            return EncryptionPassword.EncryptThePassword(originalPassword).ToString();
        }

        public static Users Find(string username, string password)
        {
            password = EncryptInputPassword(password);

            if (UsersData.IsUserValid(username, password))
                return new Users(username, password);

            else
                return null;
        }

        public static int GetUserIDByUsername(string username)
        {
            return UsersData.GetUserIDByUsername(username);
        }

        public static short GetPermissionsByUserID(int userID)
        {
            return UsersData.GetPermissionsByUserID(userID);
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

        private bool AddNewUser()
        {
            this.Password = EncryptInputPassword(this.Password);

            this.UserID = UsersData.AddNewUser(this.Username, this.Permissions, this.Password, this.PersonID);

            return (UserID != -1);
        }

        public static bool DeleteUser(string username)
        {
            return UsersData.DeleteUser(username);
        }

        public bool UpdateUser()
        {
            this.Password = EncryptInputPassword(this.Password);

            return UsersData.UpdateUser(this.Username, this.Permissions, this.Password);
        }

        public bool Save()
        {
            if (IsEmptyValidation() || IsNotNumericValidation())
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

                case enMode.Update:
                    return UpdateUser();
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
    }
}
