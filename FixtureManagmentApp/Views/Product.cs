using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FixtureManagmentApp.Controllers;
using FixtureManagmentApp.FormRestrictions;

namespace FixtureManagmentApp.Views
{
    public partial class Product : MetroFramework.Forms.MetroForm
    {
        public Product()
        {
            InitializeComponent();
            radioEkle.Checked = true;
            this.ControlBox = false;
            txtYeniUrunTuru.Visible = false;
            GridGuncelle();
            gridUrun.AllowUserToResizeColumns = false;
            gridUrun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridUrun.Columns[gridUrun.ColumnCount - 1].Visible = false;
        }

        private void radioEkle_CheckedChanged(object sender, EventArgs e)
        {
            bool ekleChecked = radioEkle.Checked ? true : false;
            btnIslem.Text = ekleChecked ? "Ekle" : "Güncelle";

            cmbUrunTuru.DataSource = UrunController.Instance.UrunTipiListesi();
        }

        private void gridUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                txtUrunAdi.Text = gridUrun.CurrentRow.Cells[0].Value.ToString();
                txtUrunOzellik.Text = gridUrun.CurrentRow.Cells[2].Value.ToString();
                cmbUrunTuru.SelectedItem = gridUrun.CurrentRow.Cells[1].Value.ToString();
            }
        }

        void GridGuncelle()
        {
            gridUrun.DataSource = UrunController.Instance.UrunListesi();
            gridUrun.Columns[0].HeaderText = "Ürün Adı";
            gridUrun.Columns[1].HeaderText = "Kategori";
            gridUrun.Columns[2].HeaderText = "Ürün Özellikleri";
        }

        private void txtUrunAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpecialTextbox.Instance.ChangeCurrentTextbox(txtUrunAdi);
            e.Handled = SpecialTextbox.Instance.IsOverLimit(50);
        }

        private void txtYeniUrunTuru_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpecialTextbox.Instance.ChangeCurrentTextbox(txtYeniUrunTuru);
            e.Handled = SpecialTextbox.Instance.IsOverLimit(30);
        }

        private void txtUrunOzellik_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpecialTextbox.Instance.ChangeCurrentTextbox(txtUrunOzellik);
            e.Handled = SpecialTextbox.Instance.IsOverLimit(50);
        }

        private void cbYeniUrunTuru_CheckedChanged_1(object sender, EventArgs e)
        {
            txtYeniUrunTuru.Visible = cbYeniUrunTuru.Checked ? true : false;
            cmbUrunTuru.Visible = txtYeniUrunTuru.Visible ? false : true;
        }

        private void btnIslem_Click_1(object sender, EventArgs e)
        {
            bool ekleChecked = radioEkle.Checked ? true : false;
            string urunTuru = cbYeniUrunTuru.Checked ? txtYeniUrunTuru.Text : cmbUrunTuru.Text;
            string msg="";
            if (EmptyOrNullChecker.Instance.NotNullableControls(this))
                msg = "Lütfen alanları eksiksiz doldurunuz.";
            else if (ekleChecked)
            {
                msg = UrunController.Instance.UrunEkle(new ViewModels.UrunGridView { UrunAd = txtUrunAdi.Text, UrunOzellik = txtUrunOzellik.Text, UrunTur = urunTuru });
            }
            else if (!ekleChecked)
            {
                msg = UrunController.Instance.UrunGuncelle(new ViewModels.UrunGridView { UrunAd = txtUrunAdi.Text, UrunOzellik = txtUrunOzellik.Text, UrunTur = urunTuru });
            }
            MetroFramework.MetroMessageBox.Show(this, msg, " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int selectedRow = gridUrun.CurrentRow.Index;
            GridGuncelle();
            gridUrun.Rows[selectedRow].Selected = true;
        }
    }
}
