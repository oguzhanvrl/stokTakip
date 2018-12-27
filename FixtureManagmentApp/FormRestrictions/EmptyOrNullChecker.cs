using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixtureManagmentApp.FormRestrictions
{
    public class EmptyOrNullChecker
    {
        private static EmptyOrNullChecker instance;
        private EmptyOrNullChecker() { }
        public static EmptyOrNullChecker Instance { get { if (instance == null) instance = new EmptyOrNullChecker(); return instance; } }

        public bool NotNullableControls(MetroFramework.Forms.MetroForm form)
        {
            List<Control> controls = new List<Control>();
            foreach (Control item in form.Controls)
            {
                if (item is MetroFramework.Controls.MetroTextBox)
                {
                    controls.Add(item);
                }
                else if (item is MetroFramework.Controls.MetroDateTime)
                {

                }
                else if (item is MetroFramework.Controls.MetroComboBox)
                {
                    controls.Add(item); ;
                }
            }
            return IsEmptyOrNull(controls);
        }

        private bool IsEmptyOrNull(List<Control> controls)// listede boş var mı bakıyor.
        {
            foreach (Control item in controls)
            {
                if (String.IsNullOrEmpty(item.Text))
                    return true;
            }
            return false;
        }
    }
}
