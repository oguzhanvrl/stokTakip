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
            gridUrun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            gridUrun.Columns[gridUrun.ColumnCount - 1].Visible = false;
        }

        private void radioEkle_CheckedChanged(object sender, EventArgs e)
        {
            bool ekleChecked = radioEkle.Checked ? true : false;
            btnIslem.Text = ekleChecked ? "Ekle" : "Güncelle";

            cmbUrunTuru.DataSource = UrunController.Instance.UrunTipiListesi();
        }

        private void cbYeniUrunTuru_CheckedChanged(object sender, EventArgs e)
        {
            txtYeniUrunTuru.Visible = cbYeniUrunTuru.Checked ? true : false;
            cmbUrunTuru.Visible = txtYeniUrunTuru.Visible ? false : true;
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            bool ekleChecked = radioEkle.Checked ? true : false;
            string urunTuru = cbYeniUrunTuru.Checked ? txtYeniUrunTuru.Text : cmbUrunTuru.Text;
            string msg;
            if (ekleChecked)
            {
                msg = UrunController.Instance.UrunEkle(new ViewModels.UrunGridView { UrunAd = txtUrunAdi.Text, UrunOzellik = txtUrunOzellik.Text, UrunTur = urunTuru });      
            }
            else
            {
                msg = UrunController.Instance.UrunGuncelle(new ViewModels.UrunGridView { UrunAd = txtUrunAdi.Text, UrunOzellik = txtUrunOzellik.Text, UrunTur = urunTuru });
            }
            MetroFramework.MetroMessageBox.Show(this, msg, " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int selectedRow = gridUrun.CurrentRow.Index;
            GridGuncelle();
            gridUrun.Rows[selectedRow].Selected = true;
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
        }
    }
}
