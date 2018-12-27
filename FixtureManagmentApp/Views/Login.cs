using FixtureManagmentApp.Controllers;
using FixtureManagmentApp.FormRestrictions;
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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {   
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnGiris.Click += new EventHandler(LoginClick);
            txtSifre.KeyDown += new KeyEventHandler(EnterKeyPress);
            txtKullaniciAdi.KeyDown += new KeyEventHandler(EnterKeyPress);
            this.KeyDown += new KeyEventHandler(EnterKeyPress);
        }

        private void EnterKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnGiris.PerformClick();
            }
        }

        private void LoginClick(object sender, EventArgs e)
        {
            LoginView kullanici = new LoginView();
            kullanici.kullaniciAdi = txtKullaniciAdi.Text;
            kullanici.Sifre = txtSifre.Text;

            if (txtSifre.Text.Length < 8)
            {
                MetroFramework.MetroMessageBox.Show(this, "Şifre 8 karakterden uzun olmalıdır.", "Şifre Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txtKullaniciAdi.Text.Length<4)
            {
                MetroFramework.MetroMessageBox.Show(this, "Kullanıcı adı 4 karakterden uzun olmalıdır.", "Kullanıcı Adı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(EmptyOrNullChecker.Instance.NotNullableControls(this))
            {
                MetroFramework.MetroMessageBox.Show(this, "Kullanıcı adı veya şifre boş.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (PersonelController.Instance.GirisYap(kullanici))
            {
                MainScreen main = new MainScreen();
                this.Hide();
                main.Show();               
            }
            else MetroFramework.MetroMessageBox.Show(this, "Kullanıcı adı veya şifreniz yanlış!", "Böyle Bir Kullanıcı Yok", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lbSifreyiGoster_MouseEnter(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '\0';
        }

        private void lbSifreyiGoster_MouseLeave(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpecialTextbox.Instance.ChangeCurrentTextbox(txtKullaniciAdi);
            if (SpecialTextbox.Instance.IsOverLimit(20, e.KeyChar) || SpecialTextbox.Instance.IsIDPW(e.KeyChar))
            e.Handled = true;
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpecialTextbox.Instance.ChangeCurrentTextbox(txtSifre);
            if (SpecialTextbox.Instance.IsOverLimit(20, e.KeyChar) || SpecialTextbox.Instance.IsIDPW(e.KeyChar))
                e.Handled = true;
        }
    }
}
