using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixtureManagmentApp.ViewModels
{
    public class AtikGridView
    {
        public string Personel { get; set; }

        public string Urun { get; set; }

        public string Not { get; set; }

        public DateTime AtikTarih { get; set; }

        public int? Adet { get; set; } 

        public int? atikID { get; set; }
    }
}
