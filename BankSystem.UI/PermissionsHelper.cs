using BankSystemBusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankSystemBusinessLayer.PermissionsEnum;
using System.Windows.Forms;

namespace BankSystem
{
    public static class PermissionsHelper
    {
        public static short GetPermissions(Guna2GradientPanel panel, Guna2CheckBox chkAll)
        {
            short permission = 0;

            if (chkAll.Checked)
                return -1;

            foreach (Control control in panel.Controls)
            {
                if (control is Guna2CheckBox checkbox && checkbox.Checked && checkbox.Tag is PermissionsEnum.enPermissions selectedPermission)
                {
                    permission += (short)selectedPermission;
                }
            }

            return permission;
        }

        public static void LoadUserPermission(short userPermission, Guna2GradientPanel panel, Guna2CheckBox chkAll)
        {
            if (userPermission == -1)
            {
                chkAll.Checked = true;
                return;

            }

            foreach (Control control in panel.Controls)
            {
                if (control is Guna2CheckBox checkbox && checkbox.Tag is PermissionsEnum.enPermissions permission)
                {
                    checkbox.Checked = ((userPermission & (short)permission) == (short)permission);
                }
            }
        }
    }
}
