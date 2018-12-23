using FixtureManagmentApp.Controllers;
using FixtureManagmentApp.Models;
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
    public partial class Staff : MetroFramework.Forms.MetroForm
    {
        StokController stokController;
        public Staff()
        {
            stokController = new StokController();
            InitializeComponent();
            dateGiris.MaxDate = DateTime.Now;
            dateCikis.MaxDate = DateTime.Now;
            radioEkle.Checked = true;
            GridGuncelle();
            this.ControlBox = false;
        }

        public void GridGuncelle()
        {
            gridPersonel.DataSource = stokController.PersonelGridListesi();
        }

        private void dateGiris_ValueChanged(object sender, EventArgs e)
        {
            if (dateGiris.Value.ToShortDateString() == DateTime.Now.Date.ToShortDateString())
            {
                MessageBox.Show(dateGiris.Value.ToShortDateString());//tarih dönüşümü
            }
        }

        private void dateGiris_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dateGiris.MaxDate = DateTime.Now;//tarih seçme için tıklandığında en fazla bugünün tarihini girebilir
            }
        }

        private void dateCikis_ValueChanged(object sender, EventArgs e)
        {
            if (dateCikis.Value.ToShortDateString() == DateTime.Now.Date.ToShortDateString())
            {
                MessageBox.Show(dateCikis.Value.ToShortDateString());//tarih dönüşümü
            }
        }

        private void dateCikis_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dateCikis.MaxDate = DateTime.Now;//tarih seçme için tıklandığında en fazla bugünün tarihini girebilir
            }
        }

      
        private void radioEkle_CheckedChanged(object sender, EventArgs e)
        {
            bool ekleChecked = radioEkle.Checked ? true : false;
            btnIslem.Text = ekleChecked ? "Ekle" : "Güncelle";

            cmbDepartman.DataSource = stokController.Departmanlar();
            cmbPerTip.DataSource = stokController.Tipler();

            if (ekleChecked)
            {
                cbAktif.Checked = true;
                cbAktif.Enabled = false;

                dateCikis.Visible = false;
                lblCikis.Visible = false;
            }
            else
            {
                cbAktif.Checked = false;
                cbAktif.Enabled = true;

                dateCikis.Visible = true;
                lblCikis.Visible = true;
            }       
               

        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            bool ekleChecked = radioEkle.Checked ? true : false;
            if (ekleChecked)
            {
                try
                {
                    using (StokDBEntities stokDB = new StokDBEntities())
                    {
                        Personel per = new Personel();
                        int maxPerID = stokDB.Personels.Max(p => p.perID);
                        per.perID = maxPerID + 100;

                        per.perIsim = txtAdSoyad.Text;
                        per.perAktif = cbAktif.Checked;
                        per.perTipID = stokController.KullaniTipIDBul(cmbPerTip.Text);
                        per.bolumID = stokController.KullaniBolumIDBul(cmbDepartman.Text);
                        per.perIseGiris = dateGiris.Value.Date;
                        per.perTCNo = txtTC.Text;

                        stokDB.Personels.Add(per);
                        stokDB.SaveChanges();
                        GridGuncelle();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata");
                }
                
            }
            else
            {
                try
                {
                    using (StokDBEntities stokDB = new StokDBEntities())
                    {
                        Personel per = stokDB.Personels.FirstOrDefault(p => p.perTCNo == txtTC.Text);
                        if (per!= null)
                        {
                            try
                            {
                                per.perIsim = txtAdSoyad.Text;
                                per.perTCNo = txtTC.Text;
                                per.bolumID = stokController.KullaniBolumIDBul(cmbDepartman.Text);
                                per.perTipID = stokController.KullaniTipIDBul(cmbPerTip.Text);
                                per.perAktif = cbAktif.Checked;
                                per.perIseGiris = dateGiris.Value.Date;
                                per.perIsCikis = dateCikis.Value.Date;

                                stokDB.SaveChanges();                               
                                MessageBox.Show("Personel Başarıyla Güncellendi.");
                                GridGuncelle();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Hata");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Personel Bulunamadı !");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata");
                }
            }
        }

        private void gridPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAdSoyad.Text = gridPersonel.CurrentRow.Cells[0].Value.ToString();
            cmbDepartman.SelectedValue =gridPersonel.CurrentRow.Cells[1].Value.ToString();
            cmbPerTip.SelectedValue = gridPersonel.CurrentRow.Cells[2].Value.ToString();
            cbAktif.Checked = (bool)gridPersonel.CurrentRow.Cells[3].Value;
            dateGiris.Value = (DateTime)gridPersonel.CurrentRow.Cells[4].Value;
            dateCikis.Value = (DateTime)gridPersonel.CurrentRow.Cells[5].Value;
            txtTC.Text = gridPersonel.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
