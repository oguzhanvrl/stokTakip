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
            gridRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            radioBolum.Checked = true;
        }

        private void radioBolum_CheckedChanged(object sender, EventArgs e)
        {
            using (StokDBEntities stokDB = new StokDBEntities())
            {
                bool bolumChecked = radioBolum.Checked ? true : false;

                if (bolumChecked)
                {
                    txtBolum.Visible = true;
                    cmbAra.Visible = false;
                    txtBolum.Enabled = false;
                    txtBolum.Text = stokDB.Bolumlers.FirstOrDefault(x => x.bolumID == stokDB.Personels.FirstOrDefault(y => y.perID == Authorization.user).bolumID).bolumAdi;
                }
                else
                {
                    txtBolum.Visible = false;
                    cmbAra.Visible = true;
                   cmbAra.DataSource = (from p in stokDB.Personels select p.perIsim).ToList();
                }
            }
        }

        private void btnIslem_Click_1(object sender, EventArgs e)
        {
            if (gridRapor.DataSource == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Lütfen raporlama için kişi/bölüm seçin.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Zimmet Döküm Raporu";
                printer.SubTitle = txtBolum.Text + " >> " + cmbAra.SelectedItem.ToString();
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = string.Format("Date: {0}", DateTime.Now.Date);
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(gridRapor);
            }        
        }

        private void cmbAra_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            using (StokDBEntities stokDB = new StokDBEntities())
            {
                if (cmbAra.SelectedIndex >= 0)
                {
                    gridRapor.DataSource = null;
                    gridRapor.Refresh();
                    lblPer.Text = "Bölüm : " + txtBolum.Text + " - Kişi :";
                    if (!radioBolum.Checked)
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
