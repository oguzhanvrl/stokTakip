﻿using FixtureManagmentApp.Controllers;
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
            this.ControlBox = false;
            gridStok.DataSource = StokController.Instance.StokGridListesi();
            gridStok.Columns[0].HeaderText = "Ürün Adı";
            gridStok.Columns[1].HeaderText = "Kategori";
            gridStok.Columns[2].HeaderText = "Ürün Özellikleri";
            gridStok.Columns[3].HeaderText = "Adet";
            gridStok.AllowUserToResizeColumns = false;
            gridStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            /*
             *   int selectedRow = gridZimmet.CurrentRow.Index;     
            GridGuncelle();
            gridZimmet.Rows[selectedRow].Selected = true;
             */
        }
    }
}
