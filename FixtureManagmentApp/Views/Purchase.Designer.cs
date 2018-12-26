namespace FixtureManagmentApp.Views
{
    partial class Purchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTC = new MetroFramework.Controls.MetroLabel();
            this.txtPer = new MetroFramework.Controls.MetroTextBox();
            this.btnIslem = new MetroFramework.Controls.MetroButton();
            this.lblTarih = new MetroFramework.Controls.MetroLabel();
            this.dateTarih = new MetroFramework.Controls.MetroDateTime();
            this.radioGuncelle = new MetroFramework.Controls.MetroRadioButton();
            this.lblAdet = new MetroFramework.Controls.MetroLabel();
            this.radioEkle = new MetroFramework.Controls.MetroRadioButton();
            this.lblBirimFiyat = new MetroFramework.Controls.MetroLabel();
            this.lblAdSoyad = new MetroFramework.Controls.MetroLabel();
            this.txtBirimFiyat = new MetroFramework.Controls.MetroTextBox();
            this.gridSatinAlma = new MetroFramework.Controls.MetroGrid();
            this.cmbUrunler = new MetroFramework.Controls.MetroComboBox();
            this.txtAdet = new MetroFramework.Controls.MetroTextBox();
            this.txtFirma = new MetroFramework.Controls.MetroTextBox();
            this.lblFirma = new MetroFramework.Controls.MetroLabel();
            this.lblAra = new MetroFramework.Controls.MetroLabel();
            this.txtAra = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSatinAlma)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(1254, 276);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(93, 20);
            this.lblTC.TabIndex = 42;
            this.lblTC.Text = "Satın Alan Kişi";
            // 
            // txtPer
            // 
            // 
            // 
            // 
            this.txtPer.CustomButton.Image = null;
            this.txtPer.CustomButton.Location = new System.Drawing.Point(194, 2);
            this.txtPer.CustomButton.Name = "";
            this.txtPer.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPer.CustomButton.TabIndex = 1;
            this.txtPer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPer.CustomButton.UseSelectable = true;
            this.txtPer.CustomButton.Visible = false;
            this.txtPer.Enabled = false;
            this.txtPer.Lines = new string[0];
            this.txtPer.Location = new System.Drawing.Point(1194, 302);
            this.txtPer.MaxLength = 32767;
            this.txtPer.Name = "txtPer";
            this.txtPer.PasswordChar = '\0';
            this.txtPer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPer.SelectedText = "";
            this.txtPer.SelectionLength = 0;
            this.txtPer.SelectionStart = 0;
            this.txtPer.ShortcutsEnabled = true;
            this.txtPer.Size = new System.Drawing.Size(222, 30);
            this.txtPer.TabIndex = 41;
            this.txtPer.UseSelectable = true;
            this.txtPer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnIslem
            // 
            this.btnIslem.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnIslem.Location = new System.Drawing.Point(1194, 576);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(222, 96);
            this.btnIslem.TabIndex = 40;
            this.btnIslem.Text = "Ekle";
            this.btnIslem.UseSelectable = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(1249, 163);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(109, 20);
            this.lblTarih.TabIndex = 38;
            this.lblTarih.Text = "Satın Alma Tarihi";
            // 
            // dateTarih
            // 
            this.dateTarih.CustomFormat = "dd.MM.yyyy";
            this.dateTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTarih.Location = new System.Drawing.Point(1192, 197);
            this.dateTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dateTarih.MaxDate = new System.DateTime(2070, 1, 1, 0, 0, 0, 0);
            this.dateTarih.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateTarih.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Size = new System.Drawing.Size(224, 30);
            this.dateTarih.TabIndex = 36;
            this.dateTarih.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTarih_MouseDown);
            // 
            // radioGuncelle
            // 
            this.radioGuncelle.AutoSize = true;
            this.radioGuncelle.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.radioGuncelle.Location = new System.Drawing.Point(301, 28);
            this.radioGuncelle.Name = "radioGuncelle";
            this.radioGuncelle.Size = new System.Drawing.Size(223, 25);
            this.radioGuncelle.TabIndex = 35;
            this.radioGuncelle.Text = "Satın Alma Güncelleme";
            this.radioGuncelle.UseSelectable = true;
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(1279, 424);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(38, 20);
            this.lblAdet.TabIndex = 32;
            this.lblAdet.Text = "Adet";
            // 
            // radioEkle
            // 
            this.radioEkle.AutoSize = true;
            this.radioEkle.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.radioEkle.Location = new System.Drawing.Point(24, 28);
            this.radioEkle.Name = "radioEkle";
            this.radioEkle.Size = new System.Drawing.Size(197, 25);
            this.radioEkle.TabIndex = 34;
            this.radioEkle.Text = "Yeni Satın Alma Ekle";
            this.radioEkle.UseSelectable = true;
            this.radioEkle.CheckedChanged += new System.EventHandler(this.radioEkle_CheckedChanged);
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Location = new System.Drawing.Point(1263, 352);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(72, 20);
            this.lblBirimFiyat.TabIndex = 31;
            this.lblBirimFiyat.Text = "Birim Fiyat";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(1270, 81);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(56, 20);
            this.lblAdSoyad.TabIndex = 30;
            this.lblAdSoyad.Text = "Urunler";
            // 
            // txtBirimFiyat
            // 
            // 
            // 
            // 
            this.txtBirimFiyat.CustomButton.Image = null;
            this.txtBirimFiyat.CustomButton.Location = new System.Drawing.Point(88, 2);
            this.txtBirimFiyat.CustomButton.Name = "";
            this.txtBirimFiyat.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtBirimFiyat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBirimFiyat.CustomButton.TabIndex = 1;
            this.txtBirimFiyat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBirimFiyat.CustomButton.UseSelectable = true;
            this.txtBirimFiyat.CustomButton.Visible = false;
            this.txtBirimFiyat.Lines = new string[0];
            this.txtBirimFiyat.Location = new System.Drawing.Point(1242, 378);
            this.txtBirimFiyat.MaxLength = 32767;
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.PasswordChar = '\0';
            this.txtBirimFiyat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBirimFiyat.SelectedText = "";
            this.txtBirimFiyat.SelectionLength = 0;
            this.txtBirimFiyat.SelectionStart = 0;
            this.txtBirimFiyat.ShortcutsEnabled = true;
            this.txtBirimFiyat.Size = new System.Drawing.Size(116, 30);
            this.txtBirimFiyat.TabIndex = 29;
            this.txtBirimFiyat.UseSelectable = true;
            this.txtBirimFiyat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBirimFiyat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gridSatinAlma
            // 
            this.gridSatinAlma.AllowUserToAddRows = false;
            this.gridSatinAlma.AllowUserToDeleteRows = false;
            this.gridSatinAlma.AllowUserToResizeRows = false;
            this.gridSatinAlma.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridSatinAlma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSatinAlma.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridSatinAlma.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSatinAlma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridSatinAlma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSatinAlma.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridSatinAlma.EnableHeadersVisualStyles = false;
            this.gridSatinAlma.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridSatinAlma.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridSatinAlma.Location = new System.Drawing.Point(20, 63);
            this.gridSatinAlma.MultiSelect = false;
            this.gridSatinAlma.Name = "gridSatinAlma";
            this.gridSatinAlma.ReadOnly = true;
            this.gridSatinAlma.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSatinAlma.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridSatinAlma.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridSatinAlma.RowTemplate.Height = 24;
            this.gridSatinAlma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSatinAlma.Size = new System.Drawing.Size(1152, 531);
            this.gridSatinAlma.TabIndex = 24;
            this.gridSatinAlma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSatinAlma_CellClick);
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.ItemHeight = 24;
            this.cmbUrunler.Location = new System.Drawing.Point(1192, 111);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(224, 30);
            this.cmbUrunler.TabIndex = 27;
            this.cmbUrunler.UseSelectable = true;
            // 
            // txtAdet
            // 
            // 
            // 
            // 
            this.txtAdet.CustomButton.Image = null;
            this.txtAdet.CustomButton.Location = new System.Drawing.Point(88, 2);
            this.txtAdet.CustomButton.Name = "";
            this.txtAdet.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAdet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdet.CustomButton.TabIndex = 1;
            this.txtAdet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdet.CustomButton.UseSelectable = true;
            this.txtAdet.CustomButton.Visible = false;
            this.txtAdet.Lines = new string[0];
            this.txtAdet.Location = new System.Drawing.Point(1242, 450);
            this.txtAdet.MaxLength = 32767;
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.PasswordChar = '\0';
            this.txtAdet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdet.SelectedText = "";
            this.txtAdet.SelectionLength = 0;
            this.txtAdet.SelectionStart = 0;
            this.txtAdet.ShortcutsEnabled = true;
            this.txtAdet.Size = new System.Drawing.Size(116, 30);
            this.txtAdet.TabIndex = 43;
            this.txtAdet.UseSelectable = true;
            this.txtAdet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFirma
            // 
            // 
            // 
            // 
            this.txtFirma.CustomButton.Image = null;
            this.txtFirma.CustomButton.Location = new System.Drawing.Point(196, 2);
            this.txtFirma.CustomButton.Name = "";
            this.txtFirma.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtFirma.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirma.CustomButton.TabIndex = 1;
            this.txtFirma.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirma.CustomButton.UseSelectable = true;
            this.txtFirma.CustomButton.Visible = false;
            this.txtFirma.Lines = new string[0];
            this.txtFirma.Location = new System.Drawing.Point(1192, 525);
            this.txtFirma.MaxLength = 32767;
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.PasswordChar = '\0';
            this.txtFirma.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirma.SelectedText = "";
            this.txtFirma.SelectionLength = 0;
            this.txtFirma.SelectionStart = 0;
            this.txtFirma.ShortcutsEnabled = true;
            this.txtFirma.Size = new System.Drawing.Size(224, 30);
            this.txtFirma.TabIndex = 44;
            this.txtFirma.UseSelectable = true;
            this.txtFirma.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirma.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Location = new System.Drawing.Point(1254, 498);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(101, 20);
            this.lblFirma.TabIndex = 45;
            this.lblFirma.Text = "Tedarikçi Firma";
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAra.Location = new System.Drawing.Point(754, 20);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(183, 25);
            this.lblAra.TabIndex = 64;
            this.lblAra.Text = "Personel İsimiyle Ara :";
            // 
            // txtAra
            // 
            // 
            // 
            // 
            this.txtAra.CustomButton.Image = null;
            this.txtAra.CustomButton.Location = new System.Drawing.Point(171, 2);
            this.txtAra.CustomButton.Name = "";
            this.txtAra.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtAra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAra.CustomButton.TabIndex = 1;
            this.txtAra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAra.CustomButton.UseSelectable = true;
            this.txtAra.CustomButton.Visible = false;
            this.txtAra.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtAra.Lines = new string[0];
            this.txtAra.Location = new System.Drawing.Point(1046, 13);
            this.txtAra.MaxLength = 32767;
            this.txtAra.Name = "txtAra";
            this.txtAra.PasswordChar = '\0';
            this.txtAra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAra.SelectedText = "";
            this.txtAra.SelectionLength = 0;
            this.txtAra.SelectionStart = 0;
            this.txtAra.ShortcutsEnabled = true;
            this.txtAra.Size = new System.Drawing.Size(209, 40);
            this.txtAra.TabIndex = 63;
            this.txtAra.UseSelectable = true;
            this.txtAra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 721);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lblFirma);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.txtPer);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.dateTarih);
            this.Controls.Add(this.radioGuncelle);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.radioEkle);
            this.Controls.Add(this.lblBirimFiyat);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.gridSatinAlma);
            this.Controls.Add(this.cmbUrunler);
            this.Name = "Purchase";
            this.Style = MetroFramework.MetroColorStyle.White;
            ((System.ComponentModel.ISupportInitialize)(this.gridSatinAlma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblTC;
        private MetroFramework.Controls.MetroTextBox txtPer;
        private MetroFramework.Controls.MetroButton btnIslem;
        private MetroFramework.Controls.MetroLabel lblTarih;
        private MetroFramework.Controls.MetroDateTime dateTarih;
        private MetroFramework.Controls.MetroRadioButton radioGuncelle;
        private MetroFramework.Controls.MetroLabel lblAdet;
        private MetroFramework.Controls.MetroRadioButton radioEkle;
        private MetroFramework.Controls.MetroLabel lblBirimFiyat;
        private MetroFramework.Controls.MetroLabel lblAdSoyad;
        private MetroFramework.Controls.MetroTextBox txtBirimFiyat;
        private MetroFramework.Controls.MetroGrid gridSatinAlma;
        private MetroFramework.Controls.MetroComboBox cmbUrunler;
        private MetroFramework.Controls.MetroTextBox txtAdet;
        private MetroFramework.Controls.MetroTextBox txtFirma;
        private MetroFramework.Controls.MetroLabel lblFirma;
        private MetroFramework.Controls.MetroLabel lblAra;
        private MetroFramework.Controls.MetroTextBox txtAra;
    }
}