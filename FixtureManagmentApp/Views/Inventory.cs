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
        StokController stokController;
        public Inventory()
        {
            stokController = new StokController();
            InitializeComponent();
            gridStok.DataSource = stokController.StokGridListesi();
        }   
    }
}
