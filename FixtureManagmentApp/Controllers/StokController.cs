using FixtureManagmentApp.Models;
using FixtureManagmentApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixtureManagmentApp.Controllers
{
    public class StokController
    {
        #region Singleton
        private static StokController instance;
        public static StokController Instance
        {
            get
            {
                if (instance == null) instance = new StokController();
                return instance;
            }
        }
        #endregion
  
        public void StokGuncelle(int? urunID, int? urunAdet)
        {
            try
            {
                using (StokDBEntities stokDB = new StokDBEntities())
                {
                    int maxSTOKID = stokDB.Stoks.Max(s => s.stokID);
                    Stok stok = stokDB.Stoks.FirstOrDefault(s => s.urunID == urunID);
                    if (stok!=null)
                    {
                        stok.stokAdet += urunAdet;
                        stok.stokAktif = true;
                    }
                    else
                    {
                        Stok stk = new Stok
                        {
                            stokID = maxSTOKID + 100,
                            urunID = urunID,
                            stokAdet = urunAdet,
                            stokAktif = false,
                        };
                        stokDB.Stoks.Add(stk);
                    }               
                    stokDB.SaveChanges();                   
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Hata StokGuncelleme");
            }
        }

        public List<StokGridView> StokGridListesi()
        {
            using (StokDBEntities stokDB = new StokDBEntities())
            {
                return (from stk in stokDB.Stoks
                        join urn in stokDB.Urunlers on stk.urunID equals urn.urunID
                        join urntur in stokDB.UrunTurs on urn.urunTurID equals urntur.urunTurID
                        where stk.stokAktif == true
                        select new StokGridView()
                        {
                            UrunAd = urn.urunBilgi,
                            UrunBilgi = urn.urunOzellik,
                            UrunTur = urntur.urunTurAdi,
                            Adet = stk.stokAdet
                        }).ToList<StokGridView>();
            }
        }
    }
}
