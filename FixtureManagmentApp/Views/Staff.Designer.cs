namespace FixtureManagmentApp.Views
{
    partial class Staff
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
            this.gridPersonel = new MetroFramework.Controls.MetroGrid();
            this.txtArama = new MetroFramework.Controls.MetroTextBox();
            this.lblArama = new MetroFramework.Controls.MetroLabel();
            this.radioEkle = new MetroFramework.Controls.MetroRadioButton();
            this.radioGuncelle = new MetroFramework.Controls.MetroRadioButton();
            this.cbAktif = new MetroFramework.Controls.MetroCheckBox();
            this.cmbDepartman = new MetroFramework.Controls.MetroComboBox();
            this.cmbPerTip = new MetroFramework.Controls.MetroComboBox();
            this.txtAdSoyad = new MetroFramework.Controls.MetroTextBox();
            this.lblAdSoyad = new MetroFramework.Controls.MetroLabel();
            this.lblDepartman = new MetroFramework.Controls.MetroLabel();
            this.lblPerTip = new MetroFramework.Controls.MetroLabel();
            this.dateGiris = new MetroFramework.Controls.MetroDateTime();
            this.dateCikis = new MetroFramework.Controls.MetroDateTime();
            this.lblGiris = new MetroFramework.Controls.MetroLabel();
            this.lblCikis = new MetroFramework.Controls.MetroLabel();
            this.btnIslem = new MetroFramework.Controls.MetroButton();
            this.txtTC = new MetroFramework.Controls.MetroTextBox();
            this.lblTC = new MetroFramework.Controls.MetroLabel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPersonel
            // 
            this.gridPersonel.AllowUserToResizeRows = false;
            this.gridPersonel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPersonel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPersonel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridPersonel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPersonel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPersonel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPersonel.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridPersonel.EnableHeadersVisualStyles = false;
            this.gridPersonel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridPersonel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPersonel.Location = new System.Drawing.Point(23, 81);
            this.gridPersonel.MultiSelect = false;
            this.gridPersonel.Name = "gridPersonel";
            this.gridPersonel.ReadOnly = true;
            this.gridPersonel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPersonel.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridPersonel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPersonel.RowTemplate.Height = 24;
            this.gridPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPersonel.Size = new System.Drawing.Size(753, 449);
            this.gridPersonel.TabIndex = 0;
            this.gridPersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPersonel_CellClick);
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
            this.txtArama.Location = new System.Drawing.Point(674, 34);
            this.txtArama.MaxLength = 32767;
            this.txtArama.Name = "txtArama";
            this.txtArama.PasswordChar = '\0';
            this.txtArama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtArama.SelectedText = "";
            this.txtArama.SelectionLength = 0;
            this.txtArama.SelectionStart = 0;
            this.txtArama.ShortcutsEnabled = true;
            this.txtArama.Size = new System.Drawing.Size(102, 23);
            this.txtArama.TabIndex = 1;
            this.txtArama.UseSelectable = true;
            this.txtArama.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtArama.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Location = new System.Drawing.Point(546, 34);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(122, 20);
            this.lblArama.TabIndex = 11;
            this.lblArama.Text = "Personel İsim Ara :";
            // 
            // radioEkle
            // 
            this.radioEkle.AutoSize = true;
            this.radioEkle.Location = new System.Drawing.Point(162, 37);
            this.radioEkle.Name = "radioEkle";
            this.radioEkle.Size = new System.Drawing.Size(101, 17);
            this.radioEkle.TabIndex = 12;
            this.radioEkle.Text = "Personel Ekle";
            this.radioEkle.UseSelectable = true;
            this.radioEkle.CheckedChanged += new System.EventHandler(this.radioEkle_CheckedChanged);
            // 
            // radioGuncelle
            // 
            this.radioGuncelle.AutoSize = true;
            this.radioGuncelle.Location = new System.Drawing.Point(286, 37);
            this.radioGuncelle.Name = "radioGuncelle";
            this.radioGuncelle.Size = new System.Drawing.Size(127, 17);
            this.radioGuncelle.TabIndex = 13;
            this.radioGuncelle.Text = "Personel Güncelle";
            this.radioGuncelle.UseSelectable = true;
            // 
            // cbAktif
            // 
            this.cbAktif.AutoSize = true;
            this.cbAktif.Location = new System.Drawing.Point(874, 282);
            this.cbAktif.Name = "cbAktif";
            this.cbAktif.Size = new System.Drawing.Size(73, 17);
            this.cbAktif.TabIndex = 2;
            this.cbAktif.Text = "Çalışıyor";
            this.cbAktif.UseSelectable = true;
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.ItemHeight = 24;
            this.cmbDepartman.Location = new System.Drawing.Point(845, 163);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(121, 30);
            this.cmbDepartman.TabIndex = 3;
            this.cmbDepartman.UseSelectable = true;
            // 
            // cmbPerTip
            // 
            this.cmbPerTip.FormattingEnabled = true;
            this.cmbPerTip.ItemHeight = 24;
            this.cmbPerTip.Location = new System.Drawing.Point(845, 230);
            this.cmbPerTip.Name = "cmbPerTip";
            this.cmbPerTip.Size = new System.Drawing.Size(121, 30);
            this.cmbPerTip.TabIndex = 4;
            this.cmbPerTip.UseSelectable = true;
            // 
            // txtAdSoyad
            // 
            // 
            // 
            // 
            this.txtAdSoyad.CustomButton.Image = null;
            this.txtAdSoyad.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtAdSoyad.CustomButton.Name = "";
            this.txtAdSoyad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdSoyad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdSoyad.CustomButton.TabIndex = 1;
            this.txtAdSoyad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdSoyad.CustomButton.UseSelectable = true;
            this.txtAdSoyad.CustomButton.Visible = false;
            this.txtAdSoyad.Lines = new string[0];
            this.txtAdSoyad.Location = new System.Drawing.Point(845, 52);
            this.txtAdSoyad.MaxLength = 32767;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.PasswordChar = '\0';
            this.txtAdSoyad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdSoyad.SelectedText = "";
            this.txtAdSoyad.SelectionLength = 0;
            this.txtAdSoyad.SelectionStart = 0;
            this.txtAdSoyad.ShortcutsEnabled = true;
            this.txtAdSoyad.Size = new System.Drawing.Size(102, 23);
            this.txtAdSoyad.TabIndex = 5;
            this.txtAdSoyad.UseSelectable = true;
            this.txtAdSoyad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdSoyad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(845, 29);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(67, 20);
            this.lblAdSoyad.TabIndex = 7;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // lblDepartman
            // 
            this.lblDepartman.AutoSize = true;
            this.lblDepartman.Location = new System.Drawing.Point(845, 140);
            this.lblDepartman.Name = "lblDepartman";
            this.lblDepartman.Size = new System.Drawing.Size(79, 20);
            this.lblDepartman.TabIndex = 8;
            this.lblDepartman.Text = "Departman";
            // 
            // lblPerTip
            // 
            this.lblPerTip.AutoSize = true;
            this.lblPerTip.Location = new System.Drawing.Point(845, 207);
            this.lblPerTip.Name = "lblPerTip";
            this.lblPerTip.Size = new System.Drawing.Size(85, 20);
            this.lblPerTip.TabIndex = 9;
            this.lblPerTip.Text = "Personel Tip";
            // 
            // dateGiris
            // 
            this.dateGiris.CustomFormat = "dd.MM.yyyy";
            this.dateGiris.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateGiris.Location = new System.Drawing.Point(809, 364);
            this.dateGiris.Margin = new System.Windows.Forms.Padding(4);
            this.dateGiris.MaxDate = new System.DateTime(2070, 1, 1, 0, 0, 0, 0);
            this.dateGiris.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateGiris.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateGiris.Name = "dateGiris";
            this.dateGiris.Size = new System.Drawing.Size(203, 30);
            this.dateGiris.TabIndex = 17;
            this.dateGiris.ValueChanged += new System.EventHandler(this.dateGiris_ValueChanged);
            this.dateGiris.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateGiris_MouseDown);
            // 
            // dateCikis
            // 
            this.dateCikis.CustomFormat = "dd.MM.yyyy";
            this.dateCikis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCikis.Location = new System.Drawing.Point(809, 432);
            this.dateCikis.Margin = new System.Windows.Forms.Padding(4);
            this.dateCikis.MaxDate = new System.DateTime(2070, 1, 1, 0, 0, 0, 0);
            this.dateCikis.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateCikis.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateCikis.Name = "dateCikis";
            this.dateCikis.Size = new System.Drawing.Size(203, 30);
            this.dateCikis.TabIndex = 18;
            this.dateCikis.ValueChanged += new System.EventHandler(this.dateCikis_ValueChanged);
            this.dateCikis.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateCikis_MouseDown);
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Location = new System.Drawing.Point(854, 330);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(93, 20);
            this.lblGiris.TabIndex = 19;
            this.lblGiris.Text = "İşe Giriş Tarihi";
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Location = new System.Drawing.Point(845, 408);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(110, 20);
            this.lblCikis.TabIndex = 20;
            this.lblCikis.Text = "İşden Çıkış Tarihi";
            // 
            // btnIslem
            // 
            this.btnIslem.Location = new System.Drawing.Point(845, 479);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(140, 36);
            this.btnIslem.TabIndex = 21;
            this.btnIslem.Text = "Ekle";
            this.btnIslem.UseSelectable = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // txtTC
            // 
            // 
            // 
            // 
            this.txtTC.CustomButton.Image = null;
            this.txtTC.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtTC.CustomButton.Name = "";
            this.txtTC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTC.CustomButton.TabIndex = 1;
            this.txtTC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTC.CustomButton.UseSelectable = true;
            this.txtTC.CustomButton.Visible = false;
            this.txtTC.Lines = new string[0];
            this.txtTC.Location = new System.Drawing.Point(845, 108);
            this.txtTC.MaxLength = 32767;
            this.txtTC.Name = "txtTC";
            this.txtTC.PasswordChar = '\0';
            this.txtTC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTC.SelectedText = "";
            this.txtTC.SelectionLength = 0;
            this.txtTC.SelectionStart = 0;
            this.txtTC.ShortcutsEnabled = true;
            this.txtTC.Size = new System.Drawing.Size(102, 23);
            this.txtTC.TabIndex = 22;
            this.txtTC.UseSelectable = true;
            this.txtTC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(864, 84);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(48, 20);
            this.lblTC.TabIndex = 23;
            this.lblTC.Text = "TC No";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ad Soyad";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Departman";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Yetki";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Çalışıyor";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Giriş Tarihi";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Çıkış Tarihi";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "TC KimlikNo";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 553);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.lblCikis);
            this.Controls.Add(this.lblGiris);
            this.Controls.Add(this.dateCikis);
            this.Controls.Add(this.dateGiris);
            this.Controls.Add(this.radioGuncelle);
            this.Controls.Add(this.lblPerTip);
            this.Controls.Add(this.radioEkle);
            this.Controls.Add(this.lblDepartman);
            this.Controls.Add(this.lblArama);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.gridPersonel);
            this.Controls.Add(this.cmbPerTip);
            this.Controls.Add(this.cmbDepartman);
            this.Controls.Add(this.cbAktif);
            this.Name = "Staff";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Staff";
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridPersonel;
        private MetroFramework.Controls.MetroTextBox txtArama;
        private MetroFramework.Controls.MetroLabel lblArama;
        private MetroFramework.Controls.MetroRadioButton radioEkle;
        private MetroFramework.Controls.MetroRadioButton radioGuncelle;
        private MetroFramework.Controls.MetroCheckBox cbAktif;
        private MetroFramework.Controls.MetroComboBox cmbDepartman;
        private MetroFramework.Controls.MetroComboBox cmbPerTip;
        private MetroFramework.Controls.MetroTextBox txtAdSoyad;
        private MetroFramework.Controls.MetroLabel lblAdSoyad;
        private MetroFramework.Controls.MetroLabel lblDepartman;
        private MetroFramework.Controls.MetroLabel lblPerTip;
        private MetroFramework.Controls.MetroDateTime dateGiris;
        private MetroFramework.Controls.MetroDateTime dateCikis;
        private MetroFramework.Controls.MetroLabel lblGiris;
        private MetroFramework.Controls.MetroLabel lblCikis;
        private MetroFramework.Controls.MetroButton btnIslem;
        private MetroFramework.Controls.MetroTextBox txtTC;
        private MetroFramework.Controls.MetroLabel lblTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}