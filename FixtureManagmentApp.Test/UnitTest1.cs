using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FixtureManagmentApp.Controllers;
using FixtureManagmentApp.Views;
using FixtureManagmentApp.ViewModels;
using FixtureManagmentApp.Models;

namespace FixtureManagmentApp.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void KullaniciGirisi()
        {
            LoginView kullanici = new LoginView {
                kullaniciAdi = "sef2",
                Sifre = "123123123"
            };

            bool giris = PersonelController.Instance.GirisYap(kullanici);
            Assert.IsTrue(giris);
        }

        [TestMethod]
        public void UrunEkle()
        {
            UrunGridView urun = new UrunGridView {
                UrunAd = "monster abra a5",
                UrunOzellik = "240 gb ssd 1 tb hdd",
                UrunTur = "Notebook"
            };

            string urunMesaj = UrunController.Instance.UrunEkle(urun);
            Assert.IsTrue(urunMesaj.Contains("Yeni ürün ekleme tamamlandı."));
        }

        [TestMethod]
        public void SatinAlmaEkleme()
        {
            SatinAlmaGridView satinAlma = new SatinAlmaGridView {
                Adet = 5,
                BirimFiyat = 10,
                Firma = "Kardeşler LTD ŞTİ",
                Personel = "oguzhan",
                Tarih = DateTime.Now.Date,
                Urun = "monster abra a5"
            };

            string satinAlmaMesaj = SatinAlmaController.Instance.SatinAl(satinAlma);
            Assert.IsTrue(satinAlmaMesaj.Contains("Satın alma işlemi tamamlandı."));
        }

        [TestMethod]
        public void PersoneleUrunZimmetleme()
        {
            ZimmetGridView zimmet = new ZimmetGridView {
                Personel = "oguzhan",
                Urun = "monster abra a5",
                ZimmetAdet=3,
                ZimmetTarih= DateTime.Now.Date
            };

            string zimmetMesaj = ZimmetController.Instance.ZimmetEkle(zimmet);
            Assert.AreEqual<string>(zimmetMesaj, "Zimmete ekleme tamamlandı.");
        }

        [TestMethod]
        public void ZimettenAtigaAtma()
        {         
            Zimmet zimmett = new Zimmet{ zimmetID=411 };

            string atikMesaj = AtikController.Instance.AtikEkle(zimmett, 2);
            Assert.AreEqual<string>(atikMesaj, "Atiğa ekleme tamamlandı.");
        }
    }
}
