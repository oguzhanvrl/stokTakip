using FixtureManagmentApp.FormRestrictions;
using FixtureManagmentApp.Models;
using FixtureManagmentApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixtureManagmentApp.Controllers
{
    public class SatinAlmaController
    {
        #region Singleton
        private static SatinAlmaController instance;
        public static SatinAlmaController Instance
        {
            get
            {
                if (instance == null) instance = new SatinAlmaController();
                return instance;
            }
        }
        #endregion

        public string SatinAl(SatinAlmaGridView sa)
        {
            try
            {
                using (StokDBEntities stokDB = new StokDBEntities())
                {
                    int maxSAID = stokDB.SatinAlmas.Max(s => s.saID);
                    SatinAlma p = new SatinAlma
                    {
                        saID = maxSAID + 100,
                        perID = Authorization.user,
                        saAdet = sa.Adet,
                        saBirimFiyat = sa.BirimFiyat,
                        saTarih = sa.Tarih,
                        saTedarikciFirma = sa.Firma
                    };
                    stokDB.SatinAlmas.Add(p);
                    stokDB.SaveChanges();
                    return "Satın alma işlemi tamamlandı.";
                }
            }
            catch (Exception)
            {
                return "Sunucu hatası.";
            }
        }

        public string SatinAlGuncelle(SatinAlmaGridView sa)
        {
            string msg;
            try
            {
                using (StokDBEntities stokDB = new StokDBEntities())
                {
                    SatinAlma p = stokDB.SatinAlmas.FirstOrDefault(s=>s.saID == sa.saID);
                    if (p != null)
                    {
                        try
                        {
                            p.urunID = UrunController.Instance.UrunIDBul(sa.Urun);
                            p.saAdet = sa.Adet;
                            p.saBirimFiyat = sa.BirimFiyat;
                            p.saTarih = sa.Tarih;
                            p.saTedarikciFirma = sa.Firma;

                            stokDB.SaveChanges();
                            msg = "Satın alma işleminizdeki kayıt başarıyla güncellendi.";
                        }
                        catch (Exception)
                        {
                            msg = "Hata1";
                        }
                    }
                    else
                    {
                        msg = "Satın alma işlemi Bulunamadı !";
                    }
                }
            }
            catch (Exception)
            {
                msg = "Hata2";
            }
            return msg;
        }

        public List<SatinAlmaGridView> SatinAlmaGridListesi()
        {
            using (StokDBEntities stokDB = new StokDBEntities())
            {
                return (from sa in stokDB.SatinAlmas
                        join per in stokDB.Personels on sa.perID equals per.perID
                        join urn in stokDB.Urunlers on sa.urunID equals urn.urunID
                        select new SatinAlmaGridView()
                        {
                            Personel = per.perIsim,
                            Urun = urn.urunBilgi,
                            Adet = sa.saAdet,
                            BirimFiyat = sa.saBirimFiyat,
                            Firma = sa.saTedarikciFirma,
                            Tarih = sa.saTarih,
                            saID = sa.saID
                        }).ToList<SatinAlmaGridView>();
            }
        }
    }
}
