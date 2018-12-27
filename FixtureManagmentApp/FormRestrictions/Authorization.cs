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
        public static int user { get; set; }

        private Authorization()
        {
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

        public MetroFramework.Forms.MetroForm[] AdminForms(StaffTypes type)
        {
            switch (type)
            {
                case StaffTypes.Yönetici:
                    return new MetroFramework.Forms.MetroForm[7] { new Views.Purchase(), new Views.Inventory(), new Views.Product(), new Views.Fixture(), new Views.Recycle(), new Views.Staff(), new Views.Report() };
                case StaffTypes.SatınAlma:
                    return new MetroFramework.Forms.MetroForm[5] { new Views.Purchase(), new Views.Inventory(), new Views.Product(), new Views.Fixture(), new Views.Recycle() };
                case StaffTypes.BölümŞefi:
                    return new MetroFramework.Forms.MetroForm[1] {new Views.Report() };
                default:
                    return null;
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

        public string[] TabControlPageNames(StaffTypes type)
        {
            switch (type)
            {
                case StaffTypes.Yönetici:
                    return Enum.GetNames(typeof(TabControlPages)).Select(x => "       " + x.ToString() + "       ").ToArray();
                case StaffTypes.SatınAlma:
                    return Enum.GetNames(typeof(TabControlPages)).Select(x => "       " + x.ToString() + "       ").Take(5).ToArray();
                case StaffTypes.BölümŞefi:
                    return new string[1] { "Rapor" };
                default:
                    return null;
            }            
        }
    }
}
