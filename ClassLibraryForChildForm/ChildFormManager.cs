using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClassLibraryForChildForm
{
    public static class ChildFormManager
    {
        
        private static void ClearPanelForms(Panel panel)
        {
            if (panel.Controls.Count > 0)
            {
                foreach (Control control in panel.Controls)
                {
                    if (control is Form existingForm)
                    {
                        existingForm.Close();
                        existingForm.Dispose();
                    }
                }

                panel.Controls.Clear();
            }
        }

        private static void LoadChildFormToPanel(Form childForm, Panel panel)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public static void OpenChildForm(Form childForm, Panel panel)
        {
            try
            {
                ClearPanelForms(panel);

                LoadChildFormToPanel(childForm, panel);
            }

            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the child form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }
    }
}
