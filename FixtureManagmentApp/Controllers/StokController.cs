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
                            perID=per.perID,
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

    }
}
