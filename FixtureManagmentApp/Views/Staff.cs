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
using FixtureManagmentApp.FormRestrictions;

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
            gridPersonel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridPersonel.Columns[3].ValueType = typeof(bool);
            gridPersonel.Columns[gridPersonel.ColumnCount - 1].Visible = false;
            this.ControlBox = false;
        }

        public void GridGuncelle()
        {
            gridPersonel.DataSource = PersonelController.Instance.PersonelGridListesi();
            gridPersonel.Columns[0].HeaderText = "T.C. Kimlik No";
            gridPersonel.Columns[1].HeaderText = "Ad Soyad";
            gridPersonel.Columns[2].HeaderText = "Departman";
            gridPersonel.Columns[3].HeaderText = "Kullanıcı Tipi";
            gridPersonel.Columns[4].HeaderText = "Çalışıyor";
            gridPersonel.Columns[5].HeaderText = "İşe Giriş Tarihi";
            gridPersonel.Columns[6].HeaderText = "İşten Çıkış Tarihi";
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

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpecialTextbox.Instance.ChangeCurrentTextbox(txtTC);
            if(SpecialTextbox.Instance.IsOverLimit(11)|| SpecialTextbox.Instance.IsNotNumeric(e.KeyChar))
                e.Handled = true;
        }

        private void txtKul_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpecialTextbox.Instance.ChangeCurrentTextbox(txtTC);
            if (SpecialTextbox.Instance.IsOverLimit(20) || SpecialTextbox.Instance.IsIDPW(e.KeyChar))
                e.Handled = true;
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpecialTextbox.Instance.ChangeCurrentTextbox(txtSifre);
            if (SpecialTextbox.Instance.IsOverLimit(20) || SpecialTextbox.Instance.IsIDPW(e.KeyChar))
                e.Handled = true;
        }

        private void txtSifre_MouseEnter(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '\0';
        }

        private void txtSifre_MouseLeave(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpecialTextbox.Instance.ChangeCurrentTextbox(txtAdSoyad);
            if (SpecialTextbox.Instance.IsOverLimit(50) || SpecialTextbox.Instance.IsNotLetter(e.KeyChar))
                e.Handled = true;
        }

        private void btnIslem_Click_1(object sender, EventArgs e)
        {
            bool ekleChecked = radioEkle.Checked ? true : false;
            if (EmptyOrNullChecker.Instance.NotNullableControls(this)||txtTC.Text.Length<11||txtKul.Text.Length<4||txtSifre.Text.Length<8)
                MetroFramework.MetroMessageBox.Show(this, "Lütfen alanları eksiksiz doldurun.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (ekleChecked)
            {
                try
                {
                    using (StokDBEntities stokDB = new StokDBEntities())
                    {
                        if (cmbDepartman.Enabled && cmbDepartman.SelectedIndex <= 1)
                            MessageBox.Show("Bu bölümleri seçemezsiniz .");
                        else
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
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata");
                }
            }
            else if(!ekleChecked)
            {
                try
                {
                    using (StokDBEntities stokDB = new StokDBEntities())
                    {
                        Personel per = stokDB.Personels.FirstOrDefault(p => p.perTCNo == txtTC.Text);
                        if (per != null)
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

        private void dateGiris_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dateGiris.MaxDate = DateTime.Now;//tarih seçme için tıklandığında en fazla bugünün tarihini girebilir
            }
        }

        private void cmbPerTip_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbPerTip.SelectedIndex == 0 || cmbPerTip.SelectedIndex == 1)
            {
                panel.Visible = true;
                cmbDepartman.Enabled = false;
                cmbDepartman.SelectedIndex = cmbPerTip.SelectedIndex;
            }
            else if (cmbPerTip.SelectedIndex == 2)
            {
                panel.Visible = true;
                cmbDepartman.Enabled = true;
            }
            else
            {
                panel.Visible = false;
                cmbDepartman.Enabled = true;
            }
        }
    }
}
