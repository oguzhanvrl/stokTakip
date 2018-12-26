using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixtureManagmentApp.ViewModels
{
    public class ZimmetGridView
    {
        public string Urun { get; set; }

        public string Personel { get; set; }

        public DateTime ZimmetTarih { get; set; }

        public int? ZimmetAdet { get; set; }

        public int? ZimmetID { get; set; }
    }
}
