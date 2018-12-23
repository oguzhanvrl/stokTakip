using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixtureManagmentApp.ViewModels
{
    public class PersonelGridView
    {
        public string AdSoyad{ get; set; }

        public string Bölüm { get; set; }

        public string Tip { get; set; }

        public bool? Aktif { get; set; }

        public DateTime? GirisTarih { get; set; }

        public DateTime? CikisTarih { get; set; }

        public string TCNo { get; set; }
    }
}
