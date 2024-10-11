using System;
using System.Data;
using BankSystemDataAccessLayer;

namespace BankSystemBusinessLayer
{
    public class Users
    {
        public enum enMode { AddNew = 0, Update = 1};
        public enMode mode = enMode.AddNew;

        public int userID { get; set; }
        public string username { get; set; }
        public int permissions { get; set; }
        public string password { get; set; }
        public int personID { get; set; }

        public Users()
        {
            this.userID = -1;
            this.username = "";
            this.permissions = -1;
            this.password = "";
            this.personID = -1;

            mode = enMode.AddNew;
        }
        private Users(int userID, string username, int permissions, string password, int personID)
        {
            this.userID = userID;
            this.username = username;
            this.permissions = permissions;
            this.password = password;
            this.personID = personID;

            mode = enMode.Update;
        }

        public static Users Find(string username)
        {
            int userID = -1;


        }



       
    }
}
