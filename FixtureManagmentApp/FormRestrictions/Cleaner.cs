using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixtureManagmentApp.FormRestrictions
{
    public class Cleaner
    {
        private static Cleaner instance;
        private Cleaner() { }
        public static Cleaner Instance { get { if (instance == null) instance = new Cleaner(); return instance; } }

        public void ClearItems(List<Control> controls)
        {
            foreach (Control item in controls)
            {
                item.ResetText();
                if (item is MetroFramework.Controls.MetroComboBox)
                    ((MetroFramework.Controls.MetroComboBox)item).SelectedIndex = -1;
            }
        }
    }
}
