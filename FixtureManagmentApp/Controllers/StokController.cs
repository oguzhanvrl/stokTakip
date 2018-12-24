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
    class StokController
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

        public bool GirisYap(LoginView loginView)
        {
            using (StokDBEntities stokDB = new StokDBEntities())
            {
                var kullanici = stokDB.Kullanicis.FirstOrDefault(
                    x => x.kullaniciAdi == loginView.kullaniciAdi &&
                    x.kullaniciSifre == loginView.Sifre);

                if (kullanici != null)
                {
                    Authorization.user = kullanici.perID;
                    return true;
                }
            }
            return false;
        }

        public Personel KullaniciBul(int ID)// verilen ID'yi bulacak
        {
            using (StokDBEntities stokDB = new StokDBEntities())
            {
                return stokDB.Personels.FirstOrDefault(x => x.perID == ID);
            }
        }

        public Authorization.StaffTypes KullaniciTipiBul(int ID)
        {
            using (StokDBEntities stokDB = new StokDBEntities())
            {
                return (Authorization.StaffTypes)KullaniciBul(ID).perTipID;
            }
        }

        public List<string> Departmanlar()
        {
            using (StokDBEntities stokDB = new StokDBEntities())
            {
                return (from c in stokDB.Bolumlers
                        select c.bolumAdi).ToList();
            }
        }

        public List<string> Tipler()
        {
            using (StokDBEntities stokDB = new StokDBEntities())
            {
                return (from c in stokDB.PersonelTips
                        select c.perTipAdi).ToList();
            }
        }

        public int KullaniTipIDBul(string tipAd)
        {
            using (StokDBEntities stokDB = new StokDBEntities())
            {
                return stokDB.PersonelTips.FirstOrDefault(t => t.perTipAdi == tipAd).perTipID;
            }
        }


        public int KullaniBolumIDBul(string bolumAd)
        {
            using (StokDBEntities stokDB = new StokDBEntities())
            {
                return stokDB.Bolumlers.FirstOrDefault(t => t.bolumAdi == bolumAd).bolumID;
            }
        }

        public List<PersonelGridView> PersonelGridListesi()
        {
            using (StokDBEntities stokDB = new StokDBEntities())
            {
                return (from per in stokDB.Personels
                        join tip in stokDB.PersonelTips on per.perTipID equals tip.perTipID
                        join bol in stokDB.Bolumlers on per.bolumID equals bol.bolumID
                        select new PersonelGridView()
                        {
                            AdSoyad = per.perIsim,
                            Bölüm = bol.bolumAdi,
                            Tip = tip.perTipAdi,
                            Aktif = per.perAktif,
                            GirisTarih = per.perIseGiris,
                            CikisTarih = per.perIsCikis,
                            TCNo = per.perTCNo
                        }).ToList<PersonelGridView>();
            }
        }

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
                            msg="Ürün Başarıyla Güncellendi.";
                        }
                        catch (Exception)
                        {
                            msg= "Hata1";
                        }
                    }
                    else
                    {
                        msg= "Ürün Bulunamadı !";
                    }
                }
            }
            catch (Exception)
            {
                msg= "Hata2";
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
    }
}
