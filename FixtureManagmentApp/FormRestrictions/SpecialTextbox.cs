using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixtureManagmentApp.FormRestrictions
{
    public class SpecialTextbox
    {
        private MetroFramework.Controls.MetroTextBox mtbox { get; set; }
        private static SpecialTextbox inst = null;

        private SpecialTextbox()
        {

        }

        public static SpecialTextbox Instance
        {
            get
            {
                if (inst == null)
                    inst = new SpecialTextbox();
                return inst;
            }
        }

        public void ChangeCurrentTextbox(MetroFramework.Controls.MetroTextBox mtbox)
        {
            this.mtbox = mtbox;
        }

        public bool IsNotNumeric(char key)
        {
            bool isNotNumeric = key != '\b'&&!char.IsControl(key) && !char.IsDigit(key) ? true : false;
            return isNotNumeric;
        }

        public bool IsNotFloat(char key)
        {
            if (IsNotNumeric(key) && key != '.' && key != '\b')
                return true;
            bool isNotFloat = (key == '.') && (mtbox.Text.IndexOf('.') > -1) ? true : false;
            return isNotFloat;
        }

        public bool IsOverLimit(int limit,char key)
        {
            if (key == '\b')
                return false;
            bool isOverLimit = mtbox.Text.Length >= limit ? true : false;
            return isOverLimit;
        }

        public bool IsUnderLimit(int limit)
        {
            bool isUnderLimit = mtbox.Text.Length <= limit ? true : false;
            return isUnderLimit;
        }

        public bool IsNotLetter(char key)
        {
            bool isNotLetter = !char.IsLetter(key) && key != '\b' && key != ' ' ? true : false;
            return isNotLetter;
        }

        public bool IsIDPW(char key)//sadece numara,harf ve silme tuşu
        {
            return !(char.IsNumber(key) || char.IsLetter(key) || key == '\b');
        }
    }
}

