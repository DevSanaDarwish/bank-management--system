using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
