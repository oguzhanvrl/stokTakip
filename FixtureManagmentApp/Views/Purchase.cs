using FixtureManagmentApp.Controllers;
using FixtureManagmentApp.FormRestrictions;
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
            gridSatinAlma.AllowUserToResizeColumns = false;
            gridSatinAlma.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridSatinAlma.Columns[gridSatinAlma.ColumnCount - 1].Visible = false; // saID gizlendi
        }

        public void GridGuncelle()
        {
            gridSatinAlma.DataSource = SatinAlmaController.Instance.SatinAlmaGridListesi();
            gridSatinAlma.Columns[0].HeaderText = "Ürün Adı";
            gridSatinAlma.Columns[1].HeaderText = "Satın Alma Tarihi";
            gridSatinAlma.Columns[2].HeaderText = "Satın Alan Kişi";
            gridSatinAlma.Columns[3].HeaderText = "Ürün Birim Fiyatı";
            gridSatinAlma.Columns[4].HeaderText = "Ürün Adedi";
            gridSatinAlma.Columns[5].HeaderText = "Tedarikçi Firma";
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

        private void gridSatinAlma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                cmbUrunler.SelectedItem = gridSatinAlma.CurrentRow.Cells[0].Value.ToString();
                dateTarih.Value = (DateTime)gridSatinAlma.CurrentRow.Cells[1].Value;
                txtPer.Text = gridSatinAlma.CurrentRow.Cells[2].Value.ToString();
                txtBirimFiyat.Text = gridSatinAlma.CurrentRow.Cells[3].Value.ToString();
                txtAdet.Text = gridSatinAlma.CurrentRow.Cells[4].Value.ToString();
                txtFirma.Text = gridSatinAlma.CurrentRow.Cells[5].Value.ToString();
            }           
        }

        private void txtBirimFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpecialTextbox.Instance.ChangeCurrentTextbox(txtBirimFiyat);
            if (SpecialTextbox.Instance.IsOverLimit(10) || SpecialTextbox.Instance.IsNotNumeric(e.KeyChar))
                e.Handled = true;
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpecialTextbox.Instance.ChangeCurrentTextbox(txtAdet);
            if(SpecialTextbox.Instance.IsOverLimit(9) || SpecialTextbox.Instance.IsNotNumeric(e.KeyChar))
                e.Handled =true ;
        }

        private void txtFirma_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpecialTextbox.Instance.ChangeCurrentTextbox(txtFirma);
            e.Handled = SpecialTextbox.Instance.IsOverLimit(50);
        }

        private void btnIslem_Click_1(object sender, EventArgs e)
        {
            bool ekleChecked = radioEkle.Checked ? true : false;
            string msg="";
            if (EmptyOrNullChecker.Instance.NotNullableControls(this))
                msg = "Lütfen alanları eksiksiz doldurunuz.";
            else if (ekleChecked)
            {
                msg = SatinAlmaController.Instance.SatinAl(new ViewModels.SatinAlmaGridView
                {
                    Adet = (int.Parse)(txtAdet.Text),
                    BirimFiyat = (decimal.Parse)(txtBirimFiyat.Text),
                    Firma = txtFirma.Text,
                    Personel = txtPer.Text,
                    Tarih = dateTarih.Value,
                    Urun = cmbUrunler.Text
                });
            }
            else if(!ekleChecked)
            {
                msg = SatinAlmaController.Instance.SatinAlGuncelle(new ViewModels.SatinAlmaGridView
                {
                    saID = (int.Parse)(gridSatinAlma.CurrentRow.Cells[6].Value.ToString()),
                    Adet = (int.Parse)(txtAdet.Text),
                    BirimFiyat = (decimal.Parse)(txtBirimFiyat.Text),
                    Firma = txtFirma.Text,
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

        private void dateTarih_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dateTarih.MaxDate = DateTime.Now;//tarih seçme için tıklandığında en fazla bugünün tarihini girebilir
            }
        }
    }
}
