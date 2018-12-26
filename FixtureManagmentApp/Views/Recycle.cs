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
    public partial class Recycle : MetroFramework.Forms.MetroForm
    {
        public Recycle()
        {
            InitializeComponent();
            txtPersonel.Enabled = false;
            txtUrun.Enabled = false;
            dateTarih.Enabled = false;
            radioGeriGonder.Checked = true;
            GridGuncelle();
        }

        private void gridAtik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonel.Text = gridAtik.CurrentRow.Cells[0].Value.ToString();
            txtUrun.Text = gridAtik.CurrentRow.Cells[1].Value.ToString();
            txtNot.Text = gridAtik.CurrentRow.Cells[2].Value.ToString();
            dateTarih.Value = (DateTime)gridAtik.CurrentRow.Cells[3].Value;
            txtAdet.Text = gridAtik.CurrentRow.Cells[4].Value.ToString();
        }

        private void radioGeriGonder_CheckedChanged(object sender, EventArgs e)
        {
            bool aktarChecked = radioGeriGonder.Checked ? true : false;
            btnIslem.Text = aktarChecked ? "Stoğa aktar" : "Atığı yok et!";          
        }

        public void GridGuncelle()
        {
            gridAtik.DataSource = AtikController.Instance.AtilGridListesi();
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            if (radioGeriGonder.Checked)
            {
                string msg = AtikController.Instance.StokGeriGonder(new AtikGridView
                {
                    Urun = txtUrun.Text,
                    Adet = (int.Parse)(txtAdet.Text),
                    atikID = (int.Parse)(gridAtik.CurrentRow.Cells[5].Value.ToString())
                });
                MetroFramework.MetroMessageBox.Show(this, msg, "Atık İşlem Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string msg = AtikController.Instance.AtikYokEt(new AtikGridView
                {
                    Adet = (int.Parse)(txtAdet.Text),
                    Not = txtNot.Text,
                    atikID = (int.Parse)(gridAtik.CurrentRow.Cells[5].Value.ToString())
                });
                MetroFramework.MetroMessageBox.Show(this, msg, "Atık İşlem Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            int selectedRow = gridAtik.CurrentRow.Index;
            GridGuncelle();
            gridAtik.Rows[selectedRow].Selected = true;
        }
    }
}
