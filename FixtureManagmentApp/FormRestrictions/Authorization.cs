using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixtureManagmentApp.FormRestrictions
{
    public class Authorization
    {
        private static Authorization inst = null;
        public static string[] tabNames { get; set; }
        public static int user { get; set; }

        private Authorization()
        {
            tabNames = SetTabControlPageNames();
        }

        public static Authorization Instance
        {
            get
            {
                if (inst == null)
                    inst = new Authorization();
                return inst;
            }
        }

        public static MetroFramework.Forms.MetroForm[] Forms
        {
            get
            {
                return new MetroFramework.Forms.MetroForm[3] { new Views.Form1() , new Views.Staff(), new Views.Product()};
            }
        }

        public enum TabControlPages
        {
            SatınAl,
            Stok,
            Ürünler,
            Zimmet,
            Atık,
            Personel,
            Rapor
        };

        public enum StaffTypes
        {
            Yönetici=1,
            SatınAlma,
            BölümŞefi,
            Personel
        };

        private string[] SetTabControlPageNames()
        {
            //return Enum.GetValues(typeof(TabControlPages)).Cast<int>().Select(x => "       " + x.ToString() + "       ").ToArray();
            return Enum.GetNames(typeof(TabControlPages)).Select(x => "       " + x.ToString() + "       ").ToArray();
        }

    }
}
