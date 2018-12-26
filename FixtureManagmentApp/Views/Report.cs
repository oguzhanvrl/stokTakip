using DGVPrinterHelper;
using FixtureManagmentApp.Controllers;
using FixtureManagmentApp.FormRestrictions;
using FixtureManagmentApp.Models;
using FixtureManagmentApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixtureManagmentApp.Views
{
    public partial class Report : MetroFramework.Forms.MetroForm
    {
        public Report()
        {
            InitializeComponent();
            radioBolum.Checked = true;
        }

        private void radioBolum_CheckedChanged(object sender, EventArgs e)
        {
            using (StokDBEntities stokDB = new StokDBEntities())
            {
                bool bolumChecked = radioBolum.Checked ? true : false;
                btnIslem.Text = bolumChecked ? "Bölüme Göre Rapor Çıktısı" : "Kişiye Göre Rapor Çıktısı";

                if (bolumChecked)
                {
                    cmbAra.Enabled = false;
                    lblPer.Text = stokDB.Bolumlers.FirstOrDefault(x => x.bolumID == stokDB.Personels.FirstOrDefault(y => y.perID == Authorization.user).bolumID).bolumAdi;
                }
                else
                {
                   cmbAra.Enabled = true;
                   cmbAra.DataSource = (from p in stokDB.Personels select p.perIsim).ToList();
                }
            }
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Zimmet Döküm Raporu";
            printer.SubTitle = cmbAra.SelectedItem.ToString();
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = string.Format("Date: {0}", DateTime.Now.Date);
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(gridRapor);
        }

        private void cmbAra_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (StokDBEntities stokDB = new StokDBEntities())
            {
                if (cmbAra.SelectedIndex >=0)
                {
                    gridRapor.DataSource = null;
                    gridRapor.Refresh();
                    if (radioBolum.Checked)
                    {
                        gridRapor.DataSource = (from zim in stokDB.Zimmets
                                                 join urn in stokDB.Urunlers on zim.urunID equals urn.urunID
                                                 join per in stokDB.Personels on zim.perID equals per.perID
                                                 join bol in stokDB.Bolumlers on per.bolumID equals bol.bolumID
                                                 where bol.bolumAdi == cmbAra.SelectedItem.ToString()

                                                 select new ViewModels.ZimmetGridView
                                                 {
                                                     Personel = per.perIsim,
                                                     Urun = urn.urunBilgi,
                                                     ZimmetAdet = zim.zimmetAdet,
                                                     ZimmetID = zim.zimmetID,
                                                     ZimmetTarih = zim.zimmetTarih.Value
                                                 }).ToList();
                    }
                    else
                    {
                        gridRapor.DataSource = (from zim in stokDB.Zimmets
                                                join urn in stokDB.Urunlers on zim.urunID equals urn.urunID
                                                join per in stokDB.Personels on zim.perID equals per.perID
                                                where per.perIsim == cmbAra.SelectedItem.ToString()

                                                select new ViewModels.ZimmetGridView
                                                {
                                                    Personel = per.perIsim,
                                                    Urun = urn.urunBilgi,
                                                    ZimmetAdet = zim.zimmetAdet,
                                                    ZimmetID = zim.zimmetID,
                                                    ZimmetTarih = zim.zimmetTarih.Value
                                                }).ToList();
                    }
                }
            }
        }
    }
}
