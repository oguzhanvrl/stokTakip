using FixtureManagmentApp.Models;
using FixtureManagmentApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixtureManagmentApp.Controllers
{
    public class ZimmetController
    {
        #region Singleton
        private static ZimmetController instance;

        private ZimmetController() { }

        public static ZimmetController Instance { get { if (instance == null) instance = new ZimmetController(); return instance; } }
        #endregion

        public List<ZimmetGridView> ZimmetGridListesi()
        {
            using (StokDBEntities stokDB = new StokDBEntities())
            {
                return (from zim in stokDB.Zimmets
                        join urn in stokDB.Urunlers on zim.urunID equals urn.urunID
                        join per in stokDB.Personels on zim.perID equals per.perID
                        where zim.zimmetAktif == true
                        select new ZimmetGridView()
                        {
                            Personel = per.perIsim,
                            Urun = urn.urunBilgi,
                            ZimmetAdet = zim.zimmetAdet,
                            ZimmetTarih = zim.zimmetTarih.Value,
                            ZimmetID=zim.zimmetID
                        }).ToList<ZimmetGridView>();
            }
        }

        public string ZimmetEkle(ZimmetGridView zc)
        {
            try
            {
                using (StokDBEntities stokDB = new StokDBEntities())
                {
                    int zimmetID=stokDB.Zimmets.Max(x=>x.zimmetID)+100;
                    int uID= UrunController.Instance.UrunIDBul(zc.Urun);
                    if (zc.ZimmetAdet > stokDB.Stoks.FirstOrDefault(x => x.urunID == uID).stokAdet)
                        return "Stokta yeterli ürün yok.";
                    Zimmet z = new Zimmet
                    {
                        perID = PersonelController.Instance.KullaniciIDBul(zc.Personel) + 100,
                        urunID = uID,
                        zimmetAdet = zc.ZimmetAdet,
                        zimmetTarih = zc.ZimmetTarih,
                        zimmetAktif=true,
                        zimmetID=zimmetID
                    };
                    stokDB.Zimmets.Add(z);
                    StokController.Instance.StokGuncelle(uID, -z.zimmetAdet);// stoktan düşme işlemi burada
                    stokDB.SaveChanges();
                    return "Zimmete ekleme tamamlandı.";
                }
            }
            catch (Exception)
            {
                return "Zimmet hatası.";
            }
        }

        public string ZimmetGuncelle(ZimmetGridView zc)
        {
            string msg;
            try
            {
                using (StokDBEntities stokDB = new StokDBEntities())
                {
                    Zimmet zim = stokDB.Zimmets.FirstOrDefault(z => z.zimmetID == zc.ZimmetID);
                    if (zim != null)
                    {
                        try
                        {
                            if (zc.ZimmetAdet -zim.zimmetAdet > stokDB.Stoks.FirstOrDefault(x => x.urunID == zim.urunID).stokAdet)
                                return "Stokta yeterli ürün yok.";

                            if (zc.ZimmetAdet < zim.zimmetAdet)
                            {
                                return AtikController.Instance.AtikEkle(zim, (zc.ZimmetAdet - zim.zimmetAdet));
                            }

                            else if (zc.ZimmetAdet > zim.zimmetAdet)
                                StokController.Instance.StokGuncelle(zim.urunID, -(zc.ZimmetAdet - zim.zimmetAdet)); // stoktan düşürme işlemi

                            zim.zimmetAdet = zc.ZimmetAdet;
                            zim.zimmetTarih = zc.ZimmetTarih;
                            zim.zimmetAktif = (zc.ZimmetAdet == 0) ? false : true;
                          
                            stokDB.SaveChanges();
                            msg = "Zşmmet Başarıyla Güncellendi.";
                        }
                        catch (Exception)
                        {
                            msg = "Zimmet Güncelleme Hatası";
                        }
                    }
                    else
                    {
                        msg = "Zimmet Bulunamadı !";
                    }
                }
            }
            catch (Exception)
            {
                msg = "Zimmet Hata";
            }
            return msg;
        }

    }
}
