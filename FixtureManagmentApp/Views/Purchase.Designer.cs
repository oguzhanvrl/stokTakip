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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radioGuncelle = new MetroFramework.Controls.MetroRadioButton();
            this.radioEkle = new MetroFramework.Controls.MetroRadioButton();
            this.gridSatinAlma = new MetroFramework.Controls.MetroGrid();
            this.lblFirma = new MetroFramework.Controls.MetroLabel();
            this.txtFirma = new MetroFramework.Controls.MetroTextBox();
            this.txtAdet = new MetroFramework.Controls.MetroTextBox();
            this.lblTC = new MetroFramework.Controls.MetroLabel();
            this.txtPer = new MetroFramework.Controls.MetroTextBox();
            this.btnIslem = new MetroFramework.Controls.MetroButton();
            this.lblTarih = new MetroFramework.Controls.MetroLabel();
            this.dateTarih = new MetroFramework.Controls.MetroDateTime();
            this.lblAdet = new MetroFramework.Controls.MetroLabel();
            this.lblBirimFiyat = new MetroFramework.Controls.MetroLabel();
            this.lblAdSoyad = new MetroFramework.Controls.MetroLabel();
            this.txtBirimFiyat = new MetroFramework.Controls.MetroTextBox();
            this.cmbUrunler = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSatinAlma)).BeginInit();
            this.SuspendLayout();
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
            // gridSatinAlma
            // 
            this.gridSatinAlma.AllowUserToAddRows = false;
            this.gridSatinAlma.AllowUserToDeleteRows = false;
            this.gridSatinAlma.AllowUserToResizeRows = false;
            this.gridSatinAlma.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridSatinAlma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSatinAlma.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridSatinAlma.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSatinAlma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSatinAlma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSatinAlma.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridSatinAlma.EnableHeadersVisualStyles = false;
            this.gridSatinAlma.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridSatinAlma.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridSatinAlma.Location = new System.Drawing.Point(335, 342);
            this.gridSatinAlma.MultiSelect = false;
            this.gridSatinAlma.Name = "gridSatinAlma";
            this.gridSatinAlma.ReadOnly = true;
            this.gridSatinAlma.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSatinAlma.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridSatinAlma.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridSatinAlma.RowTemplate.Height = 24;
            this.gridSatinAlma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSatinAlma.Size = new System.Drawing.Size(1152, 435);
            this.gridSatinAlma.TabIndex = 24;
            this.gridSatinAlma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSatinAlma_CellClick);
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Location = new System.Drawing.Point(657, 197);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(101, 20);
            this.lblFirma.TabIndex = 58;
            this.lblFirma.Text = "Tedarikçi Firma";
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
            this.txtFirma.Location = new System.Drawing.Point(801, 187);
            this.txtFirma.MaxLength = 32767;
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.PasswordChar = '\0';
            this.txtFirma.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirma.SelectedText = "";
            this.txtFirma.SelectionLength = 0;
            this.txtFirma.SelectionStart = 0;
            this.txtFirma.ShortcutsEnabled = false;
            this.txtFirma.Size = new System.Drawing.Size(224, 30);
            this.txtFirma.TabIndex = 57;
            this.txtFirma.UseSelectable = true;
            this.txtFirma.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirma.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFirma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirma_KeyPress);
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
            this.txtAdet.Location = new System.Drawing.Point(1207, 187);
            this.txtAdet.MaxLength = 32767;
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.PasswordChar = '\0';
            this.txtAdet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdet.SelectedText = "";
            this.txtAdet.SelectionLength = 0;
            this.txtAdet.SelectionStart = 0;
            this.txtAdet.ShortcutsEnabled = false;
            this.txtAdet.Size = new System.Drawing.Size(116, 30);
            this.txtAdet.TabIndex = 56;
            this.txtAdet.UseSelectable = true;
            this.txtAdet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdet_KeyPress);
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(264, 197);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(93, 20);
            this.lblTC.TabIndex = 55;
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
            this.txtPer.Location = new System.Drawing.Point(383, 187);
            this.txtPer.MaxLength = 32767;
            this.txtPer.Name = "txtPer";
            this.txtPer.PasswordChar = '\0';
            this.txtPer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPer.SelectedText = "";
            this.txtPer.SelectionLength = 0;
            this.txtPer.SelectionStart = 0;
            this.txtPer.ShortcutsEnabled = false;
            this.txtPer.Size = new System.Drawing.Size(222, 30);
            this.txtPer.TabIndex = 54;
            this.txtPer.UseSelectable = true;
            this.txtPer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnIslem
            // 
            this.btnIslem.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnIslem.Location = new System.Drawing.Point(833, 268);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(159, 56);
            this.btnIslem.TabIndex = 53;
            this.btnIslem.Text = "Ekle";
            this.btnIslem.UseSelectable = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click_1);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(657, 121);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(109, 20);
            this.lblTarih.TabIndex = 52;
            this.lblTarih.Text = "Satın Alma Tarihi";
            // 
            // dateTarih
            // 
            this.dateTarih.CustomFormat = "dd.MM.yyyy";
            this.dateTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTarih.Location = new System.Drawing.Point(801, 111);
            this.dateTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dateTarih.MaxDate = new System.DateTime(2070, 1, 1, 0, 0, 0, 0);
            this.dateTarih.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateTarih.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Size = new System.Drawing.Size(224, 30);
            this.dateTarih.TabIndex = 51;
            this.dateTarih.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTarih_MouseDown_1);
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(1093, 197);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(38, 20);
            this.lblAdet.TabIndex = 50;
            this.lblAdet.Text = "Adet";
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Location = new System.Drawing.Point(1093, 121);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(72, 20);
            this.lblBirimFiyat.TabIndex = 49;
            this.lblBirimFiyat.Text = "Birim Fiyat";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(301, 121);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(56, 20);
            this.lblAdSoyad.TabIndex = 48;
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
            this.txtBirimFiyat.Location = new System.Drawing.Point(1207, 111);
            this.txtBirimFiyat.MaxLength = 32767;
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.PasswordChar = '\0';
            this.txtBirimFiyat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBirimFiyat.SelectedText = "";
            this.txtBirimFiyat.SelectionLength = 0;
            this.txtBirimFiyat.SelectionStart = 0;
            this.txtBirimFiyat.ShortcutsEnabled = false;
            this.txtBirimFiyat.Size = new System.Drawing.Size(116, 30);
            this.txtBirimFiyat.TabIndex = 47;
            this.txtBirimFiyat.UseSelectable = true;
            this.txtBirimFiyat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBirimFiyat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBirimFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBirimFiyat_KeyPress);
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.ItemHeight = 24;
            this.cmbUrunler.Location = new System.Drawing.Point(381, 111);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(224, 30);
            this.cmbUrunler.TabIndex = 46;
            this.cmbUrunler.UseSelectable = true;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 800);
            this.Controls.Add(this.lblFirma);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.txtPer);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.dateTarih);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblBirimFiyat);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.cmbUrunler);
            this.Controls.Add(this.radioGuncelle);
            this.Controls.Add(this.radioEkle);
            this.Controls.Add(this.gridSatinAlma);
            this.Name = "Purchase";
            this.Style = MetroFramework.MetroColorStyle.White;
            ((System.ComponentModel.ISupportInitialize)(this.gridSatinAlma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroRadioButton radioGuncelle;
        private MetroFramework.Controls.MetroRadioButton radioEkle;
        private MetroFramework.Controls.MetroGrid gridSatinAlma;
        private MetroFramework.Controls.MetroLabel lblFirma;
        private MetroFramework.Controls.MetroTextBox txtFirma;
        private MetroFramework.Controls.MetroTextBox txtAdet;
        private MetroFramework.Controls.MetroLabel lblTC;
        private MetroFramework.Controls.MetroTextBox txtPer;
        private MetroFramework.Controls.MetroButton btnIslem;
        private MetroFramework.Controls.MetroLabel lblTarih;
        private MetroFramework.Controls.MetroDateTime dateTarih;
        private MetroFramework.Controls.MetroLabel lblAdet;
        private MetroFramework.Controls.MetroLabel lblBirimFiyat;
        private MetroFramework.Controls.MetroLabel lblAdSoyad;
        private MetroFramework.Controls.MetroTextBox txtBirimFiyat;
        private MetroFramework.Controls.MetroComboBox cmbUrunler;
    }
}