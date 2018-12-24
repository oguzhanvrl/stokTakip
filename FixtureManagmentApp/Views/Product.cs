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
        StokController stokController;
        public Product()
        {
            stokController = new StokController();
            InitializeComponent();
            radioEkle.Checked = true;
            this.ControlBox = false;
            txtYeniUrunTuru.Visible = false;
            GridGuncelle();
        }

        private void radioEkle_CheckedChanged(object sender, EventArgs e)
        {
            bool ekleChecked = radioEkle.Checked ? true : false;
            btnIslem.Text = ekleChecked ? "Ekle" : "Güncelle";

            cmbUrunTuru.DataSource = stokController.UrunTipiListesi();

            if (ekleChecked)
            {
               
            }
            else
            {
                
            }
        }

        private void cbYeniUrunTuru_CheckedChanged(object sender, EventArgs e)
        {
            txtYeniUrunTuru.Visible = cbYeniUrunTuru.Checked ? true : false;
            cmbUrunTuru.Visible = txtYeniUrunTuru.Visible ? false : true;
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            bool ekleChecked = radioEkle.Checked ? true : false;
            if (ekleChecked)
            {
                string urunTuru = cbYeniUrunTuru.Checked ? txtYeniUrunTuru.Text : cmbUrunTuru.Text;
                string msg=stokController.UrunEkle(new ViewModels.UrunGridView { UrunAd = txtUrunAdi.Text, UrunOzellik = txtUrunOzellik.Text, UrunTur = urunTuru });
                MetroFramework.MetroMessageBox.Show(this, msg, " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
            }
            GridGuncelle();
        }

        private void gridUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void GridGuncelle()
        {
            gridUrun.DataSource = stokController.UrunListesi();
        }
    }
}
