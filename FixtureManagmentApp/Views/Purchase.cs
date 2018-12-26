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
        public Purchase()
        {          
            InitializeComponent();
            this.ControlBox = false;
            GridGuncelle();
            radioEkle.Checked = true;
            gridSatinAlma.Columns[gridSatinAlma.ColumnCount - 1].Visible = false; // saID gizlendi
        }

        public void GridGuncelle()
        {
            gridSatinAlma.DataSource = SatinAlmaController.Instance.SatinAlmaGridListesi();
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
            cmbUrunler.DataSource = SatinAlmaController.Instance.UrunListesi();
            if (ekleChecked)
            {
                cmbUrunler.Enabled = true;
                txtPer.Enabled = true;
            }
            else
            {
                cmbUrunler.Enabled = false;
                txtPer.Enabled = false;
            }
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            bool ekleChecked = radioEkle.Checked ? true : false;
            string msg;
            if (ekleChecked)
            {
                    msg = SatinAlmaController.Instance.SatinAl(new ViewModels.SatinAlmaGridView {
                    Adet = (int.Parse)(txtAdet.Text),
                    BirimFiyat = (decimal.Parse)(txtBirimFiyat.Text),
                    Firma = lblFirma.Text,
                    Personel = txtPer.Text,
                    Tarih = dateTarih.Value,
                    Urun = cmbUrunler.Text
                });
            }
            else
            {
                    msg = SatinAlmaController.Instance.SatinAlGuncelle(new ViewModels.SatinAlmaGridView {
                    saID = (int.Parse)(gridSatinAlma.CurrentRow.Cells[6].Value.ToString()),
                    Adet = (int.Parse)(txtAdet.Text),
                    BirimFiyat = (decimal.Parse)(txtBirimFiyat.Text),
                    Firma = lblFirma.Text,
                    Personel = txtPer.Text,
                    Tarih = dateTarih.Value,
                    Urun = cmbUrunler.Text
                });
            }
            MetroFramework.MetroMessageBox.Show(this, msg, " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int selectedRow = gridSatinAlma.CurrentRow.Index;
            GridGuncelle();
            gridSatinAlma.Rows[selectedRow].Selected = true;
        }

        private void gridSatinAlma_CellClick(object sender, DataGridViewCellEventArgs e)
        {     
            cmbUrunler.SelectedItem = gridSatinAlma.CurrentRow.Cells[0].Value.ToString();
            dateTarih.Value = (DateTime)gridSatinAlma.CurrentRow.Cells[1].Value;
            txtPer.Text = gridSatinAlma.CurrentRow.Cells[2].Value.ToString();
            txtBirimFiyat.Text = gridSatinAlma.CurrentRow.Cells[3].Value.ToString();
            txtAdet.Text = gridSatinAlma.CurrentRow.Cells[4].Value.ToString();
            txtFirma.Text = gridSatinAlma.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
