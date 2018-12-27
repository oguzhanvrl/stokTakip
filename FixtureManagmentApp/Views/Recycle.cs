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
    public partial class Recycle : MetroFramework.Forms.MetroForm
    {
        public Recycle()
        {
            InitializeComponent();
            this.ControlBox = false;
            txtPersonel.Enabled = false;
            txtUrun.Enabled = false;
            dateTarih.Enabled = false;
            radioGeriGonder.Checked = true;
            GridGuncelle();
            gridAtik.Columns[gridAtik.ColumnCount - 1].Visible = false;
            gridAtik.AllowUserToResizeColumns = false;
            gridAtik.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void gridAtik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                txtPersonel.Text = gridAtik.CurrentRow.Cells[0].Value.ToString();
                txtUrun.Text = gridAtik.CurrentRow.Cells[1].Value.ToString();
                txtNot.Text = gridAtik.CurrentRow.Cells[2].Value.ToString();
                dateTarih.Value = (DateTime)gridAtik.CurrentRow.Cells[3].Value;
                txtAdet.Text = gridAtik.CurrentRow.Cells[4].Value.ToString();
            }           
        }

        private void radioGeriGonder_CheckedChanged(object sender, EventArgs e)
        {
            bool aktarChecked = radioGeriGonder.Checked ? true : false;
            btnIslem.Text = aktarChecked ? "Stoğa aktar" : "Atığı yok et!";          
        }

        public void GridGuncelle()
        {
            gridAtik.DataSource = AtikController.Instance.AtilGridListesi();
            gridAtik.Columns[0].HeaderText = "Personel Adı";
            gridAtik.Columns[1].HeaderText = "Ürün Adı";
            gridAtik.Columns[2].HeaderText = "Atık Bilgisi";
            gridAtik.Columns[3].HeaderText = "Atık Tarihi";
            gridAtik.Columns[4].HeaderText = "Adet";
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpecialTextbox.Instance.ChangeCurrentTextbox(txtAdet);
            if (SpecialTextbox.Instance.IsOverLimit(9) || SpecialTextbox.Instance.IsNotNumeric(e.KeyChar))
                e.Handled = true;
        }

        private void txtNot_KeyPress(object sender, KeyPressEventArgs e)
        {
            SpecialTextbox.Instance.ChangeCurrentTextbox(txtAdet);
            e.Handled = SpecialTextbox.Instance.IsOverLimit(100);
        }

        private void btnIslem_Click_1(object sender, EventArgs e)
        {
            string msg = "";
            if (EmptyOrNullChecker.Instance.NotNullableControls(this))
                msg = "Lütfen alanları eksiksiz doldurunuz.";
            else if (radioGeriGonder.Checked)
            {
                msg = AtikController.Instance.StokGeriGonder(new AtikGridView
                {
                    Urun = txtUrun.Text,
                    Adet = (int.Parse)(txtAdet.Text),
                    atikID = (int.Parse)(gridAtik.CurrentRow.Cells[5].Value.ToString())
                });               
            }
            else if(radioCıkar.Checked)
            {
                msg = AtikController.Instance.AtikYokEt(new AtikGridView
                {
                    Adet = (int.Parse)(txtAdet.Text),
                    Not = txtNot.Text,
                    atikID = (int.Parse)(gridAtik.CurrentRow.Cells[5].Value.ToString())
                });
            }
            MetroFramework.MetroMessageBox.Show(this, msg, "Atık İşlem Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int selectedRow = gridAtik.CurrentRow.Index;
            GridGuncelle();
            gridAtik.Rows[selectedRow].Selected = true;
        }
    }
}
