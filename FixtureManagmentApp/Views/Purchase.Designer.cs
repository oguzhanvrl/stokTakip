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
            this.lblTC = new MetroFramework.Controls.MetroLabel();
            this.txtPer = new MetroFramework.Controls.MetroTextBox();
            this.btnIslem = new MetroFramework.Controls.MetroButton();
            this.lblTarih = new MetroFramework.Controls.MetroLabel();
            this.dateTarih = new MetroFramework.Controls.MetroDateTime();
            this.radioGuncelle = new MetroFramework.Controls.MetroRadioButton();
            this.lblAdet = new MetroFramework.Controls.MetroLabel();
            this.radioEkle = new MetroFramework.Controls.MetroRadioButton();
            this.lblBirimFiyat = new MetroFramework.Controls.MetroLabel();
            this.lblArama = new MetroFramework.Controls.MetroLabel();
            this.lblAdSoyad = new MetroFramework.Controls.MetroLabel();
            this.txtBirimFiyat = new MetroFramework.Controls.MetroTextBox();
            this.gridSatinAlma = new MetroFramework.Controls.MetroGrid();
            this.cmbUrunler = new MetroFramework.Controls.MetroComboBox();
            this.txtArama = new MetroFramework.Controls.MetroTextBox();
            this.txtAdet = new MetroFramework.Controls.MetroTextBox();
            this.txtFrima = new MetroFramework.Controls.MetroTextBox();
            this.txtFirma = new MetroFramework.Controls.MetroLabel();
            this.lblGID = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridSatinAlma)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(1271, 329);
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
            this.txtPer.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtPer.CustomButton.Name = "";
            this.txtPer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPer.CustomButton.TabIndex = 1;
            this.txtPer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPer.CustomButton.UseSelectable = true;
            this.txtPer.CustomButton.Visible = false;
            this.txtPer.Enabled = false;
            this.txtPer.Lines = new string[0];
            this.txtPer.Location = new System.Drawing.Point(1269, 351);
            this.txtPer.MaxLength = 32767;
            this.txtPer.Name = "txtPer";
            this.txtPer.PasswordChar = '\0';
            this.txtPer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPer.SelectedText = "";
            this.txtPer.SelectionLength = 0;
            this.txtPer.SelectionStart = 0;
            this.txtPer.ShortcutsEnabled = true;
            this.txtPer.Size = new System.Drawing.Size(102, 23);
            this.txtPer.TabIndex = 41;
            this.txtPer.UseSelectable = true;
            this.txtPer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnIslem
            // 
            this.btnIslem.Location = new System.Drawing.Point(1251, 576);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(140, 36);
            this.btnIslem.TabIndex = 40;
            this.btnIslem.Text = "Ekle";
            this.btnIslem.UseSelectable = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(1269, 249);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(109, 20);
            this.lblTarih.TabIndex = 38;
            this.lblTarih.Text = "Satın Alma Tarihi";
            // 
            // dateTarih
            // 
            this.dateTarih.CustomFormat = "dd.MM.yyyy";
            this.dateTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTarih.Location = new System.Drawing.Point(1246, 283);
            this.dateTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dateTarih.MaxDate = new System.DateTime(2070, 1, 1, 0, 0, 0, 0);
            this.dateTarih.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateTarih.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Size = new System.Drawing.Size(170, 30);
            this.dateTarih.TabIndex = 36;
            this.dateTarih.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTarih_MouseDown);
            // 
            // radioGuncelle
            // 
            this.radioGuncelle.AutoSize = true;
            this.radioGuncelle.Location = new System.Drawing.Point(470, 58);
            this.radioGuncelle.Name = "radioGuncelle";
            this.radioGuncelle.Size = new System.Drawing.Size(156, 17);
            this.radioGuncelle.TabIndex = 35;
            this.radioGuncelle.Text = "Satın Alma Güncelleme";
            this.radioGuncelle.UseSelectable = true;
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(1268, 452);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(38, 20);
            this.lblAdet.TabIndex = 32;
            this.lblAdet.Text = "Adet";
            // 
            // radioEkle
            // 
            this.radioEkle.AutoSize = true;
            this.radioEkle.Location = new System.Drawing.Point(302, 58);
            this.radioEkle.Name = "radioEkle";
            this.radioEkle.Size = new System.Drawing.Size(139, 17);
            this.radioEkle.TabIndex = 34;
            this.radioEkle.Text = "Yeni Satın Alma Ekle";
            this.radioEkle.UseSelectable = true;
            this.radioEkle.CheckedChanged += new System.EventHandler(this.radioEkle_CheckedChanged);
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Location = new System.Drawing.Point(1269, 394);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(72, 20);
            this.lblBirimFiyat.TabIndex = 31;
            this.lblBirimFiyat.Text = "Birim Fiyat";
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Location = new System.Drawing.Point(929, 58);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(121, 20);
            this.lblArama.TabIndex = 33;
            this.lblArama.Text = "Ürün İsimiyle Ara :";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(1270, 178);
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
            this.txtBirimFiyat.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtBirimFiyat.CustomButton.Name = "";
            this.txtBirimFiyat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBirimFiyat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBirimFiyat.CustomButton.TabIndex = 1;
            this.txtBirimFiyat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBirimFiyat.CustomButton.UseSelectable = true;
            this.txtBirimFiyat.CustomButton.Visible = false;
            this.txtBirimFiyat.Lines = new string[0];
            this.txtBirimFiyat.Location = new System.Drawing.Point(1269, 417);
            this.txtBirimFiyat.MaxLength = 32767;
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.PasswordChar = '\0';
            this.txtBirimFiyat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBirimFiyat.SelectedText = "";
            this.txtBirimFiyat.SelectionLength = 0;
            this.txtBirimFiyat.SelectionStart = 0;
            this.txtBirimFiyat.ShortcutsEnabled = true;
            this.txtBirimFiyat.Size = new System.Drawing.Size(102, 23);
            this.txtBirimFiyat.TabIndex = 29;
            this.txtBirimFiyat.UseSelectable = true;
            this.txtBirimFiyat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBirimFiyat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gridSatinAlma
            // 
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
            this.gridSatinAlma.Location = new System.Drawing.Point(-39, 167);
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
            this.gridSatinAlma.Size = new System.Drawing.Size(1225, 531);
            this.gridSatinAlma.TabIndex = 24;
            this.gridSatinAlma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSatinAlma_CellClick);
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.ItemHeight = 24;
            this.cmbUrunler.Location = new System.Drawing.Point(1270, 201);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(121, 30);
            this.cmbUrunler.TabIndex = 27;
            this.cmbUrunler.UseSelectable = true;
            // 
            // txtArama
            // 
            // 
            // 
            // 
            this.txtArama.CustomButton.Image = null;
            this.txtArama.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtArama.CustomButton.Name = "";
            this.txtArama.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtArama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtArama.CustomButton.TabIndex = 1;
            this.txtArama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtArama.CustomButton.UseSelectable = true;
            this.txtArama.CustomButton.Visible = false;
            this.txtArama.Lines = new string[0];
            this.txtArama.Location = new System.Drawing.Point(1084, 58);
            this.txtArama.MaxLength = 32767;
            this.txtArama.Name = "txtArama";
            this.txtArama.PasswordChar = '\0';
            this.txtArama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtArama.SelectedText = "";
            this.txtArama.SelectionLength = 0;
            this.txtArama.SelectionStart = 0;
            this.txtArama.ShortcutsEnabled = true;
            this.txtArama.Size = new System.Drawing.Size(102, 23);
            this.txtArama.TabIndex = 25;
            this.txtArama.UseSelectable = true;
            this.txtArama.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtArama.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAdet
            // 
            // 
            // 
            // 
            this.txtAdet.CustomButton.Image = null;
            this.txtAdet.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtAdet.CustomButton.Name = "";
            this.txtAdet.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdet.CustomButton.TabIndex = 1;
            this.txtAdet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdet.CustomButton.UseSelectable = true;
            this.txtAdet.CustomButton.Visible = false;
            this.txtAdet.Lines = new string[0];
            this.txtAdet.Location = new System.Drawing.Point(1262, 478);
            this.txtAdet.MaxLength = 32767;
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.PasswordChar = '\0';
            this.txtAdet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdet.SelectedText = "";
            this.txtAdet.SelectionLength = 0;
            this.txtAdet.SelectionStart = 0;
            this.txtAdet.ShortcutsEnabled = true;
            this.txtAdet.Size = new System.Drawing.Size(102, 23);
            this.txtAdet.TabIndex = 43;
            this.txtAdet.UseSelectable = true;
            this.txtAdet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFrima
            // 
            // 
            // 
            // 
            this.txtFrima.CustomButton.Image = null;
            this.txtFrima.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtFrima.CustomButton.Name = "";
            this.txtFrima.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFrima.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFrima.CustomButton.TabIndex = 1;
            this.txtFrima.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFrima.CustomButton.UseSelectable = true;
            this.txtFrima.CustomButton.Visible = false;
            this.txtFrima.Lines = new string[0];
            this.txtFrima.Location = new System.Drawing.Point(1264, 532);
            this.txtFrima.MaxLength = 32767;
            this.txtFrima.Name = "txtFrima";
            this.txtFrima.PasswordChar = '\0';
            this.txtFrima.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFrima.SelectedText = "";
            this.txtFrima.SelectionLength = 0;
            this.txtFrima.SelectionStart = 0;
            this.txtFrima.ShortcutsEnabled = true;
            this.txtFrima.Size = new System.Drawing.Size(102, 23);
            this.txtFrima.TabIndex = 44;
            this.txtFrima.UseSelectable = true;
            this.txtFrima.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFrima.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFirma
            // 
            this.txtFirma.AutoSize = true;
            this.txtFirma.Location = new System.Drawing.Point(1262, 510);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(101, 20);
            this.txtFirma.TabIndex = 45;
            this.txtFirma.Text = "Tedarikçi Firma";
            // 
            // lblGID
            // 
            this.lblGID.AutoSize = true;
            this.lblGID.Location = new System.Drawing.Point(1271, 136);
            this.lblGID.Name = "lblGID";
            this.lblGID.Size = new System.Drawing.Size(20, 20);
            this.lblGID.TabIndex = 46;
            this.lblGID.Text = "id";
            this.lblGID.Visible = false;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 721);
            this.Controls.Add(this.lblGID);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.txtFrima);
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
            this.Controls.Add(this.lblArama);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.gridSatinAlma);
            this.Controls.Add(this.cmbUrunler);
            this.Name = "Purchase";
            this.Text = "Purchase";
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
        private MetroFramework.Controls.MetroLabel lblArama;
        private MetroFramework.Controls.MetroLabel lblAdSoyad;
        private MetroFramework.Controls.MetroTextBox txtBirimFiyat;
        private MetroFramework.Controls.MetroGrid gridSatinAlma;
        private MetroFramework.Controls.MetroComboBox cmbUrunler;
        private MetroFramework.Controls.MetroTextBox txtArama;
        private MetroFramework.Controls.MetroTextBox txtAdet;
        private MetroFramework.Controls.MetroTextBox txtFrima;
        private MetroFramework.Controls.MetroLabel txtFirma;
        private MetroFramework.Controls.MetroLabel lblGID;
    }
}