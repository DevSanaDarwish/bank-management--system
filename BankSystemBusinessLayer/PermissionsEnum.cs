using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankSystemBusinessLayer.PermissionsEnum;

namespace BankSystemBusinessLayer
{
    static public class PermissionsEnum
    {
        public enum enPermissions
        {
            All = -1,
            ShowClientsList = 1,
            FindClient = 2,
            AddNewClient = 4,
            Transaction = 8,
            DeleteClient = 16,
            ManageUsers = 32,
            UpdateClient = 64,
            LoginRegisters = 128
        }
    }
}
