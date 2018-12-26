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

        public bool IsEmptyOrNull(List<Control> controls)// listede boş var mı bakıyor.
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
