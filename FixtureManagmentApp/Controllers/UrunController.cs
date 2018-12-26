using FixtureManagmentApp.Models;
using FixtureManagmentApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixtureManagmentApp.Controllers
{
    public class UrunController
    {
        #region Singleton
        private static UrunController instance;

        private UrunController() { }

        public static UrunController Instance { get { if (instance == null) instance = new UrunController(); return instance; } }
        #endregion

        public List<string> UrunTipiListesi()
        {
            using (StokDBEntities stokDB = new StokDBEntities())
            {
                return (from c in stokDB.UrunTurs
                        select c.urunTurAdi).ToList();
            }
        }

        public List<UrunGridView> UrunListesi()
        {
            using (StokDBEntities stokDB = new StokDBEntities())
            {
                return (from u in stokDB.Urunlers
                        join t in stokDB.UrunTurs on u.urunTurID equals t.urunTurID
                        select new UrunGridView()
                        {
                            urunID=u.urunID,
                            UrunAd = u.urunBilgi,
                            UrunTur = t.urunTurAdi,
                            UrunOzellik = u.urunOzellik
                        }).ToList<UrunGridView>();
            }
        }

        public string UrunEkle(UrunGridView urun)
        {
            try
            {
                using (StokDBEntities stokDB = new StokDBEntities())
                {
                    int turID;
                    try
                    {
                        turID = UrunTurIDBul(urun.UrunTur);//ürün türünü bul
                    }
                    catch
                    {
                        turID = UrunTuruEkle(urun.UrunTur);//bulamazsan yenisini ekle
                    }

                    int maxUrunID = stokDB.Urunlers.Max(u => u.urunID);
                    Urunler p = new Urunler
                    {
                        urunID = maxUrunID + 100,
                        urunBilgi = urun.UrunAd,
                        urunOzellik = urun.UrunOzellik,
                        urunTurID = turID
                    };
                    stokDB.Urunlers.Add(p);
                    StokController.Instance.StokGuncelle(p.urunID,0);
                    stokDB.SaveChanges();

                    return "Yeni ürün ekleme tamamlandı.";
                }
            }
            catch (Exception)
            {
                return "Sunucu hatası.";
            }
        }

        public int UrunTuruEkle(string turAdi)
        {
            using (StokDBEntities stokDB = new StokDBEntities())
            {
                int turID = stokDB.UrunTurs.Max(t => t.urunTurID) + 1;//bulamazsan yenisini ekle
                stokDB.UrunTurs.Add(new UrunTur { urunTurID = turID, urunTurAdi = turAdi });
                stokDB.SaveChanges();
                return turID;
            }
        }

        public string UrunGuncelle(UrunGridView urun)
        {
            string msg;
            try
            {
                using (StokDBEntities stokDB = new StokDBEntities())
                {
                    Urunler p = stokDB.Urunlers.FirstOrDefault(u => u.urunBilgi == urun.UrunAd);
                    if (p != null)
                    {
                        try
                        {
                            p.urunBilgi = urun.UrunAd;
                            p.urunOzellik = urun.UrunOzellik;
                            p.urunTurID = UrunTurIDBul(urun.UrunTur);
                            if (p.urunTurID == null)
                                p.urunTurID = UrunTuruEkle(urun.UrunTur);
                            stokDB.SaveChanges();
                            msg = "Ürün Başarıyla Güncellendi.";
                        }
                        catch (Exception)
                        {
                            msg = "Hata1";
                        }
                    }
                    else
                    {
                        msg = "Ürün Bulunamadı !";
                    }
                }
            }
            catch (Exception)
            {
                msg = "Hata2";
            }
            return msg;
        }

        public int UrunTurIDBul(string tur)
        {
            using (StokDBEntities stokDB = new StokDBEntities())
            {
                return stokDB.UrunTurs.FirstOrDefault(t => t.urunTurAdi == tur).urunTurID;
            }
        }

        public int UrunIDBul(string urun)
        {
            using (StokDBEntities stokDB = new StokDBEntities())
            {
                return stokDB.Urunlers.FirstOrDefault(t => t.urunBilgi == urun).urunID;
            }
        }
    }
}
