using FixtureManagmentApp.Controllers;
using FixtureManagmentApp.Models;
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
    public partial class Inventory : MetroFramework.Forms.MetroForm
    {
        public Inventory()
        {
            InitializeComponent();
            gridStok.DataSource = StokController.Instance.StokGridListesi();

            /*
             *   int selectedRow = gridZimmet.CurrentRow.Index;     
            GridGuncelle();
            gridZimmet.Rows[selectedRow].Selected = true;
             */
        }
    }
}
