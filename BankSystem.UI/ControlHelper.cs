using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystemBusinessLayer;
using Guna.UI2.WinForms;

namespace BankSystem
{
    static public class ControlHelper
    {
        static public void VisibleControl(System.Windows.Forms.Control control)
        {
            control.Visible = true;
        }

        static public void HideControl(System.Windows.Forms.Control control)
        {
            control.Visible = false;
        }

        static public void EnableControl(System.Windows.Forms.Control control)
        {
            control.Enabled = true;
        }

        static public void DisableControl(System.Windows.Forms.Control control)
        {
            control.Enabled = false;
        }

        static public void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title);
        }

        static public void ColoringPanel(Panel panel, Color color)
        {
            panel.BackColor = color;
        }

        static public void ClearTextBox(TextBox textBoxControl)
        {
            //textBoxControl.Clear();

            textBoxControl.Text = string.Empty;
        }

        static public void RemoveControl(Control control)
        {
            if(control != null && control.Parent != null)
            {
                control.Parent.Controls.Remove(control);
                control.Dispose();
            }
        }

    }
}
