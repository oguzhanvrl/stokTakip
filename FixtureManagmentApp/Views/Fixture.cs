using FixtureManagmentApp.Controllers;
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
    public partial class Fixture : MetroFramework.Forms.MetroForm
    {
        public Fixture()
        {
            InitializeComponent();
            cmbPer.DataSource = (from per in PersonelController.Instance.PersonelGridListesi() select per.AdSoyad).ToList<string>();
            cmbUrunler.DataSource = (from u in UrunController.Instance.UrunListesi() select u.UrunAd).ToList<string>();
            this.ControlBox = false;
            GridGuncelle();
            radioEkle.Checked = true;
            gridZimmet.Columns[gridZimmet.ColumnCount - 1].Visible = false; // saID gizlendi
        }

        private void gridPer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbUrunler.SelectedItem = gridZimmet.CurrentRow.Cells[0].Value;
            cmbPer.SelectedItem = gridZimmet.CurrentRow.Cells[1].Value;
            dateTarih.Value = (DateTime)gridZimmet.CurrentRow.Cells[2].Value;
            txtAdet.Text = gridZimmet.CurrentRow.Cells[3].Value.ToString();
        }

        public void GridGuncelle()
        {
            gridZimmet.DataSource = ZimmetController.Instance.ZimmetGridListesi();
        }

        private void radioEkle_CheckedChanged(object sender, EventArgs e)
        {
            bool ekleChecked = radioEkle.Checked ? true : false;
            btnIslem.Text = ekleChecked ? "Zimmetle" : "Güncelle";

            if (ekleChecked)
            {
                btnIslem.Text = "Ekle";
                cmbPer.Enabled = true;
                cmbUrunler.Enabled = true;
            }
            else
            {
                btnIslem.Text = "Güncelle";
                cmbPer.Enabled = false;
                cmbUrunler.Enabled = false;
            }
        }

        private void dateTarih_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dateTarih.MaxDate = DateTime.Now;//tarih seçme için tıklandığında en fazla bugünün tarihini girebilir
            }
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            if (radioEkle.Checked)
            {
                string msg = ZimmetController.Instance.ZimmetEkle(new ZimmetGridView
                {
                    Personel = cmbPer.SelectedItem.ToString(),
                    Urun = cmbUrunler.SelectedItem.ToString(),
                    ZimmetAdet = (int.Parse)(txtAdet.Text),
                    ZimmetTarih = dateTarih.Value
                });
                MetroFramework.MetroMessageBox.Show(this, msg , "Zimmet İşlem Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string msg = ZimmetController.Instance.ZimmetGuncelle(new ZimmetGridView
                {
                    Personel = cmbPer.SelectedItem.ToString(),
                    Urun = cmbUrunler.SelectedItem.ToString(),
                    ZimmetAdet = (int.Parse)(txtAdet.Text),
                    ZimmetTarih = dateTarih.Value,
                    ZimmetID = (int.Parse)(gridZimmet.CurrentRow.Cells[4].Value.ToString())
                });
                MetroFramework.MetroMessageBox.Show(this, msg, "Zimmet İşlem Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            int selectedRow = gridZimmet.CurrentRow.Index;     
            GridGuncelle();
            gridZimmet.Rows[selectedRow].Selected = true;
        }
    }
}
