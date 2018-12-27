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
using System.Globalization;

namespace FixtureManagmentApp.Views
{
    public partial class Staff : MetroFramework.Forms.MetroForm
    {
        public Staff()
        {
            InitializeComponent();
            dateGiris.MaxDate = DateTime.Now;
            radioEkle.Checked = true;
            GridGuncelle();
            gridPersonel.AllowUserToResizeColumns = false;
            gridPersonel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            gridPersonel.Columns[3].ValueType = typeof(bool);
            gridPersonel.Columns[gridPersonel.ColumnCount - 1].Visible = false;
            this.ControlBox = false;
        }

        public void GridGuncelle()
        {
            gridPersonel.DataSource = PersonelController.Instance.PersonelGridListesi();
        }

        private void dateGiris_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dateGiris.MaxDate = DateTime.Now;//tarih seçme için tıklandığında en fazla bugünün tarihini girebilir
            }
        }

      
        private void radioEkle_CheckedChanged(object sender, EventArgs e)
        {
            bool ekleChecked = radioEkle.Checked ? true : false;
            btnIslem.Text = ekleChecked ? "Ekle" : "Güncelle";

            cmbDepartman.DataSource = PersonelController.Instance.Departmanlar();
            cmbPerTip.DataSource = PersonelController.Instance.Tipler();

            if (ekleChecked)
            {
                cbAktif.Checked = true;
                cbAktif.Enabled = false;

                lblKul.Visible = false;
            }
            else
            {
                cbAktif.Checked = false;
                cbAktif.Enabled = true;

                lblKul.Visible = true;
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
                        per.perTipID = PersonelController.Instance.KullaniTipIDBul(cmbPerTip.Text);
                        per.bolumID = PersonelController.Instance.KullaniBolumIDBul(cmbDepartman.Text);
                        per.perIseGiris = dateGiris.Value.Date;
                        per.perTCNo = txtTC.Text;

                        stokDB.Personels.Add(per);
                        MessageBox.Show("Personel Kaydı Başarıyla Oluşturuldu");

                        Kullanici kullanici = new Kullanici();
                        kullanici.perID = per.perID;
                        kullanici.kullaniciAdi = txtKul.Text;
                        kullanici.kullaniciSifre = txtSifre.Text;

                        stokDB.Kullanicis.Add(kullanici);
                        MessageBox.Show("Kullanıcı Giriş Kimliği Oluşturuldu");

                        stokDB.SaveChanges();
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
                                per.bolumID = PersonelController.Instance.KullaniBolumIDBul(cmbDepartman.Text);
                                per.perTipID = PersonelController.Instance.KullaniTipIDBul(cmbPerTip.Text);
                                per.perAktif = cbAktif.Checked;
                                per.perIseGiris = dateGiris.Value.Date;

                                stokDB.SaveChanges();                               
                                MessageBox.Show("Personel Başarıyla Güncellendi.");
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
            int selectedRow = gridPersonel.CurrentRow.Index;
            GridGuncelle();
            gridPersonel.Rows[selectedRow].Selected = true;
        }

        private void gridPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                txtTC.Text = gridPersonel.CurrentRow.Cells[0].Value.ToString();
                txtAdSoyad.Text = gridPersonel.CurrentRow.Cells[1].Value.ToString();
                cmbDepartman.SelectedItem = gridPersonel.CurrentRow.Cells[2].Value.ToString();
                cmbPerTip.SelectedItem = gridPersonel.CurrentRow.Cells[3].Value.ToString();
                cbAktif.Checked = (bool)gridPersonel.CurrentRow.Cells[4].Value;
                dateGiris.Value = (DateTime)gridPersonel.CurrentRow.Cells[5].Value;
                //dateCikis.Value = (DateTime)gridPersonel.CurrentRow.Cells[6].Value;
            }
        }

        private void cmbPerTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel.Visible = false;
            if (!cmbPerTip.SelectedItem.ToString().Contains("Personel") && radioEkle.Checked) panel.Visible = true;
        }
    }
}
