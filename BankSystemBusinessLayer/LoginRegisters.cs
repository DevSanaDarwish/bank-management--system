using System;
using System.Data;
using System.Runtime.CompilerServices;
using BankSystemDataAccessLayer;

namespace BankSystemBusinessLayer
{
    public class LoginRegisters
    {
        public int LoginRegisterID { get; set; }
        public DateTime DateTime { get; set; }
        public int UserID { get; set; }

        public LoginRegisters()
        {
            this.LoginRegisterID = -1;
            this.DateTime = DateTime.Now;
            this.UserID = -1;
        }


        public LoginRegisters(/*int loginRegisterID,*/ DateTime dateTime, int userID)
        {
            //LoginRegisterID = loginRegisterID;
            DateTime = dateTime;
            UserID = userID;
        }

        public static DataTable GetLoginRegistersList()
        {
            return LoginRegistersData.GetLoginRegistersList();
        }

        public bool AddLoginRegisters()
        {
            this.LoginRegisterID = LoginRegistersData.AddLoginRegister(this.DateTime, this.UserID);

            return (LoginRegisterID != -1);
        }
    }
}
