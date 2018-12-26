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
    public partial class MainScreen : MetroFramework.Forms.MetroForm
    {
        public MainScreen()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        SpecialTextbox specialTextbox;//textbox handler'ı
        Authorization auth;

        private void MainScreen_Load(object sender, EventArgs e)
        {
            specialTextbox = SpecialTextbox.Instance;
            auth = Authorization.Instance;
            string[] tabNames = Authorization.tabNames;
            if (PersonelController.Instance.KullaniciTipiBul(Authorization.user) == Authorization.StaffTypes.Yönetici)
            {
                foreach (string tabName in tabNames)
                {
                    mTab.TabPages.Add(new TabPage(tabName));
                }
                MetroFramework.Forms.MetroForm form = Authorization.Forms[mTab.SelectedIndex];
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    mTab.TabPages.Add(new TabPage(tabNames[i]));
                }
            }
        }

        private void MainScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && MdiChildren.Count() > 0)//esc'ye basıldıysa ve çocuk form açıksa
            {
                ActiveMdiChild.Close();
            }
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MdiChildren.Count() > 0)//eğer bir çocuk form açıksa
            {
                ActiveMdiChild.Close();//açık olanı kapat
            }

            try
            {
                Form form = Authorization.Forms[mTab.SelectedIndex];
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;//parent'in içini doldur
                form.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                form.Show();
            }
            catch
            {
                MessageBox.Show(mTab.SelectedIndex + " ");
            }
        }
    }
}
