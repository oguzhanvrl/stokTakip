using FixtureManagmentApp.Controllers;
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
    public partial class Purchase : MetroFramework.Forms.MetroForm
    {
        SatinAlmaController satinAlmaController;
        public Purchase()
        {
            satinAlmaController = new SatinAlmaController();            
            InitializeComponent();
            GridGuncelle();
            gridSatinAlma.Columns[6].Visible = false; // saID gizlendi
        }

        public void GridGuncelle()
        {
            gridSatinAlma.DataSource = satinAlmaController.SatinAlmaGridListesi();
        }

        private void dateTarih_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dateTarih.MaxDate = DateTime.Now;//tarih seçme için tıklandığında en fazla bugünün tarihini girebilir
            }
        }

        private void radioEkle_CheckedChanged(object sender, EventArgs e)
        {
            bool ekleChecked = radioEkle.Checked ? true : false;
            btnIslem.Text = ekleChecked ? "Ekle" : "Güncelle";

            cmbUrunler.DataSource = satinAlmaController.SatinAlmaGridListesi();
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            bool ekleChecked = radioEkle.Checked ? true : false;
            string msg;
            if (ekleChecked)
            {
                    msg = satinAlmaController.SatinAl(new ViewModels.SatinAlmaGridView {
                    Adet = (int.Parse)(txtAdet.Text),
                    BirimFiyat = (decimal.Parse)(txtBirimFiyat.Text),
                    Firma = txtFirma.Text,
                    Personel = txtPer.Text,
                    Tarih = dateTarih.Value,
                    Urun = cmbUrunler.SelectedText
                });
                GridGuncelle();
            }
            else
            {
                    msg = satinAlmaController.SatinAlGuncelle(new ViewModels.SatinAlmaGridView {
                    saID = (int.Parse)(gridSatinAlma.CurrentRow.Cells[6].Value.ToString()),
                    Adet = (int.Parse)(txtAdet.Text),
                    BirimFiyat = (decimal.Parse)(txtBirimFiyat.Text),
                    Firma = txtFirma.Text,
                    Personel = txtPer.Text,
                    Tarih = dateTarih.Value,
                    Urun = cmbUrunler.SelectedText
                });
                MetroFramework.MetroMessageBox.Show(this, msg, " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridGuncelle();
            }
        }

        private void gridSatinAlma_CellClick(object sender, DataGridViewCellEventArgs e)
        {     
            cmbUrunler.SelectedText = gridSatinAlma.CurrentRow.Cells[0].Value.ToString();
            txtPer.Text = gridSatinAlma.CurrentRow.Cells[1].Value.ToString();
            dateTarih.Value = (DateTime)gridSatinAlma.CurrentRow.Cells[2].Value;
            txtBirimFiyat.Text = gridSatinAlma.CurrentRow.Cells[3].Value.ToString();
            txtAdet.Text = gridSatinAlma.CurrentRow.Cells[4].Value.ToString();
            txtFirma.Text = gridSatinAlma.CurrentRow.Cells[5].Value.ToString();
            lblGID.Text = gridSatinAlma.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
