using FixtureManagmentApp.Models;
using FixtureManagmentApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixtureManagmentApp.Controllers
{
    public class AtikController
    {
        #region Singleton
        private static AtikController instance;

        private AtikController() { }

        public static AtikController Instance { get { if (instance == null) instance = new AtikController(); return instance; } }
        #endregion


        public List<AtikGridView> AtilGridListesi()
        {
            using (StokDBEntities stokDB = new StokDBEntities())
            {
                return (from atk in stokDB.AtikKontrols
                        join zim in stokDB.Zimmets on atk.zimmetID equals zim.zimmetID
                        join urn in stokDB.Urunlers on zim.urunID equals urn.urunID
                        join per in stokDB.Personels on zim.perID equals per.perID
                        where atk.atikAktif== true
                        select new AtikGridView()
                        {
                            Personel = per.perIsim,
                            Urun = urn.urunBilgi,
                            Not = atk.atikNot,
                            AtikTarih = zim.zimmetTarih.Value,
                            Adet = atk.atikAdet,
                            atikID = atk.atikID
                        }).ToList<AtikGridView>();
            }
        }


        public string AtikEkle(Zimmet zim, int? adet)
        {
            try
            {
                using (StokDBEntities stokDB = new StokDBEntities())
                {
                    int atikID = stokDB.AtikKontrols.Max(x => x.atikID) + 100;
                    AtikKontrol atk = new AtikKontrol
                    {
                        zimmetID = zim.zimmetID,
                        atikID = atikID,
                        atikAdet = adet,
                        atikAktif = true,
                        atikNot = "Zimmetden otomatik atığa gönderildi!"
                    };
                    stokDB.AtikKontrols.Add(atk);
                    stokDB.SaveChanges();
                    return "Atiğa ekleme tamamlandı.";
                }
            }
            catch (Exception)
            {
                return "Atık hatası.";
            }
        }


        public string StokGeriGonder(AtikGridView atk)
        {
            try
            {
                using (StokDBEntities stokDB = new StokDBEntities())
                {
                    int urnID = UrunController.Instance.UrunIDBul(atk.Urun);
                    if (atk.Adet > stokDB.AtikKontrols.FirstOrDefault(x => x.atikID == atk.atikID).atikAdet)
                        return "Atıkta yeterli ürün yok.";

                    StokController.Instance.StokGuncelle(urnID, atk.Adet); // stoğa ürün aktarma işlemi burada

                    AtikKontrol atik = stokDB.AtikKontrols.FirstOrDefault(a => a.atikID == atk.atikID);
                    if (atik.atikAdet == atk.Adet) atik.atikAktif = false;
                    atik.atikAdet -= atk.Adet;
                    stokDB.SaveChanges();
                    return "Stoğa geri ürün ekleme tamamlandı.";
                }
            }
            catch (Exception)
            {
                return "Atık > Stok hatası.";
            }
        }

        public string AtikYokEt(AtikGridView atk)
        {
            try
            {
                using (StokDBEntities stokDB = new StokDBEntities())
                {
                    if (atk.Adet > stokDB.AtikKontrols.FirstOrDefault(x => x.atikID == atk.atikID).atikAdet)
                        return "Atıkta yeterli ürün yok.";

                    AtikKontrol atik = stokDB.AtikKontrols.FirstOrDefault(a => a.atikID == atk.atikID);
                    if (atik.atikAdet == atk.Adet) atik.atikAktif = false;
                    else if (atk.Adet > atik.atikAdet) return "Atıkta yeterli ürün yok2.";
                    atik.atikAdet -= atk.Adet;                             
                    atik.atikNot = atk.Not;
                    stokDB.SaveChanges();
                    return "Atıktan Yok Etme işlemi tamamlandı.";
                }
            }
            catch (Exception)
            {
                return "Atık > Yok Etme hatası.";
            }
        }
    }
}
