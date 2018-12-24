using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixtureManagmentApp.ViewModels
{
    public class SatinAlmaGridView
    {
        public string Urun { get; set; }

        public DateTime? Tarih { get; set; }

        public string Personel { get; set; }

        public decimal? BirimFiyat { get; set; }

        public int? Adet { get; set; }

        public string Firma { get; set; }

        public int saID { get; set; }
    }
}
