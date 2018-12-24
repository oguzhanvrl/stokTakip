namespace FixtureManagmentApp.Views
{
    partial class Product
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
            this.lblUrunAdi = new MetroFramework.Controls.MetroLabel();
            this.cbYeniUrunTuru = new MetroFramework.Controls.MetroCheckBox();
            this.txtUrunAdi = new MetroFramework.Controls.MetroTextBox();
            this.cmbUrunTuru = new MetroFramework.Controls.MetroComboBox();
            this.txtAra = new MetroFramework.Controls.MetroTextBox();
            this.txtYeniUrunTuru = new MetroFramework.Controls.MetroTextBox();
            this.txtUrunOzellik = new MetroFramework.Controls.MetroTextBox();
            this.lblAra = new MetroFramework.Controls.MetroLabel();
            this.lblUrunTuru = new MetroFramework.Controls.MetroLabel();
            this.lblUrunOzellikleri = new MetroFramework.Controls.MetroLabel();
            this.radioGuncelle = new MetroFramework.Controls.MetroRadioButton();
            this.radioEkle = new MetroFramework.Controls.MetroRadioButton();
            this.gridUrun = new MetroFramework.Controls.MetroGrid();
            this.btnIslem = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(730, 140);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(64, 20);
            this.lblUrunAdi.TabIndex = 1;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // cbYeniUrunTuru
            // 
            this.cbYeniUrunTuru.AutoSize = true;
            this.cbYeniUrunTuru.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbYeniUrunTuru.Location = new System.Drawing.Point(873, 184);
            this.cbYeniUrunTuru.Name = "cbYeniUrunTuru";
            this.cbYeniUrunTuru.Size = new System.Drawing.Size(120, 20);
            this.cbYeniUrunTuru.TabIndex = 2;
            this.cbYeniUrunTuru.Text = "Yeni Ürün Türü";
            this.cbYeniUrunTuru.UseSelectable = true;
            this.cbYeniUrunTuru.CheckedChanged += new System.EventHandler(this.cbYeniUrunTuru_CheckedChanged);
            // 
            // txtUrunAdi
            // 
            // 
            // 
            // 
            this.txtUrunAdi.CustomButton.Image = null;
            this.txtUrunAdi.CustomButton.Location = new System.Drawing.Point(233, 2);
            this.txtUrunAdi.CustomButton.Name = "";
            this.txtUrunAdi.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtUrunAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUrunAdi.CustomButton.TabIndex = 1;
            this.txtUrunAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUrunAdi.CustomButton.UseSelectable = true;
            this.txtUrunAdi.CustomButton.Visible = false;
            this.txtUrunAdi.Lines = new string[0];
            this.txtUrunAdi.Location = new System.Drawing.Point(873, 137);
            this.txtUrunAdi.MaxLength = 32767;
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.PasswordChar = '\0';
            this.txtUrunAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrunAdi.SelectedText = "";
            this.txtUrunAdi.SelectionLength = 0;
            this.txtUrunAdi.SelectionStart = 0;
            this.txtUrunAdi.ShortcutsEnabled = true;
            this.txtUrunAdi.Size = new System.Drawing.Size(261, 30);
            this.txtUrunAdi.TabIndex = 3;
            this.txtUrunAdi.UseSelectable = true;
            this.txtUrunAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUrunAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbUrunTuru
            // 
            this.cmbUrunTuru.FormattingEnabled = true;
            this.cmbUrunTuru.ItemHeight = 24;
            this.cmbUrunTuru.Location = new System.Drawing.Point(873, 210);
            this.cmbUrunTuru.Name = "cmbUrunTuru";
            this.cmbUrunTuru.Size = new System.Drawing.Size(261, 30);
            this.cmbUrunTuru.TabIndex = 4;
            this.cmbUrunTuru.UseSelectable = true;
            // 
            // txtAra
            // 
            // 
            // 
            // 
            this.txtAra.CustomButton.Image = null;
            this.txtAra.CustomButton.Location = new System.Drawing.Point(182, 2);
            this.txtAra.CustomButton.Name = "";
            this.txtAra.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAra.CustomButton.TabIndex = 1;
            this.txtAra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAra.CustomButton.UseSelectable = true;
            this.txtAra.CustomButton.Visible = false;
            this.txtAra.Lines = new string[0];
            this.txtAra.Location = new System.Drawing.Point(500, 36);
            this.txtAra.MaxLength = 32767;
            this.txtAra.Name = "txtAra";
            this.txtAra.PasswordChar = '\0';
            this.txtAra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAra.SelectedText = "";
            this.txtAra.SelectionLength = 0;
            this.txtAra.SelectionStart = 0;
            this.txtAra.ShortcutsEnabled = true;
            this.txtAra.Size = new System.Drawing.Size(210, 30);
            this.txtAra.TabIndex = 5;
            this.txtAra.UseSelectable = true;
            this.txtAra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtYeniUrunTuru
            // 
            // 
            // 
            // 
            this.txtYeniUrunTuru.CustomButton.Image = null;
            this.txtYeniUrunTuru.CustomButton.Location = new System.Drawing.Point(233, 2);
            this.txtYeniUrunTuru.CustomButton.Name = "";
            this.txtYeniUrunTuru.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtYeniUrunTuru.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtYeniUrunTuru.CustomButton.TabIndex = 1;
            this.txtYeniUrunTuru.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtYeniUrunTuru.CustomButton.UseSelectable = true;
            this.txtYeniUrunTuru.CustomButton.Visible = false;
            this.txtYeniUrunTuru.Lines = new string[0];
            this.txtYeniUrunTuru.Location = new System.Drawing.Point(873, 210);
            this.txtYeniUrunTuru.MaxLength = 32767;
            this.txtYeniUrunTuru.Name = "txtYeniUrunTuru";
            this.txtYeniUrunTuru.PasswordChar = '\0';
            this.txtYeniUrunTuru.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtYeniUrunTuru.SelectedText = "";
            this.txtYeniUrunTuru.SelectionLength = 0;
            this.txtYeniUrunTuru.SelectionStart = 0;
            this.txtYeniUrunTuru.ShortcutsEnabled = true;
            this.txtYeniUrunTuru.Size = new System.Drawing.Size(261, 30);
            this.txtYeniUrunTuru.TabIndex = 6;
            this.txtYeniUrunTuru.UseSelectable = true;
            this.txtYeniUrunTuru.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtYeniUrunTuru.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUrunOzellik
            // 
            // 
            // 
            // 
            this.txtUrunOzellik.CustomButton.Image = null;
            this.txtUrunOzellik.CustomButton.Location = new System.Drawing.Point(233, 2);
            this.txtUrunOzellik.CustomButton.Name = "";
            this.txtUrunOzellik.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtUrunOzellik.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUrunOzellik.CustomButton.TabIndex = 1;
            this.txtUrunOzellik.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUrunOzellik.CustomButton.UseSelectable = true;
            this.txtUrunOzellik.CustomButton.Visible = false;
            this.txtUrunOzellik.Lines = new string[0];
            this.txtUrunOzellik.Location = new System.Drawing.Point(873, 318);
            this.txtUrunOzellik.MaxLength = 32767;
            this.txtUrunOzellik.Name = "txtUrunOzellik";
            this.txtUrunOzellik.PasswordChar = '\0';
            this.txtUrunOzellik.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrunOzellik.SelectedText = "";
            this.txtUrunOzellik.SelectionLength = 0;
            this.txtUrunOzellik.SelectionStart = 0;
            this.txtUrunOzellik.ShortcutsEnabled = true;
            this.txtUrunOzellik.Size = new System.Drawing.Size(261, 30);
            this.txtUrunOzellik.TabIndex = 7;
            this.txtUrunOzellik.UseSelectable = true;
            this.txtUrunOzellik.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUrunOzellik.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Location = new System.Drawing.Point(450, 39);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(30, 20);
            this.lblAra.TabIndex = 9;
            this.lblAra.Text = "Ara";
            // 
            // lblUrunTuru
            // 
            this.lblUrunTuru.AutoSize = true;
            this.lblUrunTuru.Location = new System.Drawing.Point(730, 210);
            this.lblUrunTuru.Name = "lblUrunTuru";
            this.lblUrunTuru.Size = new System.Drawing.Size(71, 20);
            this.lblUrunTuru.TabIndex = 10;
            this.lblUrunTuru.Text = "Ürün Türü";
            // 
            // lblUrunOzellikleri
            // 
            this.lblUrunOzellikleri.AutoSize = true;
            this.lblUrunOzellikleri.Location = new System.Drawing.Point(730, 318);
            this.lblUrunOzellikleri.Name = "lblUrunOzellikleri";
            this.lblUrunOzellikleri.Size = new System.Drawing.Size(105, 20);
            this.lblUrunOzellikleri.TabIndex = 11;
            this.lblUrunOzellikleri.Text = "Ürün Özellikleri";
            // 
            // radioGuncelle
            // 
            this.radioGuncelle.AutoSize = true;
            this.radioGuncelle.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radioGuncelle.Location = new System.Drawing.Point(285, 36);
            this.radioGuncelle.Name = "radioGuncelle";
            this.radioGuncelle.Size = new System.Drawing.Size(117, 20);
            this.radioGuncelle.TabIndex = 15;
            this.radioGuncelle.Text = "Ürün Güncelle";
            this.radioGuncelle.UseSelectable = true;
            // 
            // radioEkle
            // 
            this.radioEkle.AutoSize = true;
            this.radioEkle.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radioEkle.Location = new System.Drawing.Point(161, 36);
            this.radioEkle.Name = "radioEkle";
            this.radioEkle.Size = new System.Drawing.Size(87, 20);
            this.radioEkle.TabIndex = 14;
            this.radioEkle.Text = "Ürün Ekle";
            this.radioEkle.UseSelectable = true;
            this.radioEkle.CheckedChanged += new System.EventHandler(this.radioEkle_CheckedChanged);
            // 
            // gridUrun
            // 
            this.gridUrun.AllowUserToResizeRows = false;
            this.gridUrun.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridUrun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUrun.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridUrun.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUrun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUrun.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridUrun.EnableHeadersVisualStyles = false;
            this.gridUrun.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridUrun.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridUrun.Location = new System.Drawing.Point(20, 79);
            this.gridUrun.MultiSelect = false;
            this.gridUrun.Name = "gridUrun";
            this.gridUrun.ReadOnly = true;
            this.gridUrun.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUrun.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridUrun.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridUrun.RowTemplate.Height = 24;
            this.gridUrun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUrun.Size = new System.Drawing.Size(690, 465);
            this.gridUrun.TabIndex = 16;
            this.gridUrun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUrun_CellClick);
            // 
            // btnIslem
            // 
            this.btnIslem.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnIslem.Location = new System.Drawing.Point(873, 410);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(261, 79);
            this.btnIslem.TabIndex = 17;
            this.btnIslem.Text = "Ekle";
            this.btnIslem.UseSelectable = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 567);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.gridUrun);
            this.Controls.Add(this.radioGuncelle);
            this.Controls.Add(this.radioEkle);
            this.Controls.Add(this.lblUrunOzellikleri);
            this.Controls.Add(this.lblUrunTuru);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.txtUrunOzellik);
            this.Controls.Add(this.txtYeniUrunTuru);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.cmbUrunTuru);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.cbYeniUrunTuru);
            this.Controls.Add(this.lblUrunAdi);
            this.Name = "Product";
            this.Style = MetroFramework.MetroColorStyle.White;
            ((System.ComponentModel.ISupportInitialize)(this.gridUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblUrunAdi;
        private MetroFramework.Controls.MetroCheckBox cbYeniUrunTuru;
        private MetroFramework.Controls.MetroTextBox txtUrunAdi;
        private MetroFramework.Controls.MetroComboBox cmbUrunTuru;
        private MetroFramework.Controls.MetroTextBox txtAra;
        private MetroFramework.Controls.MetroTextBox txtYeniUrunTuru;
        private MetroFramework.Controls.MetroTextBox txtUrunOzellik;
        private MetroFramework.Controls.MetroLabel lblAra;
        private MetroFramework.Controls.MetroLabel lblUrunTuru;
        private MetroFramework.Controls.MetroLabel lblUrunOzellikleri;
        private MetroFramework.Controls.MetroRadioButton radioGuncelle;
        private MetroFramework.Controls.MetroRadioButton radioEkle;
        private MetroFramework.Controls.MetroGrid gridUrun;
        private MetroFramework.Controls.MetroButton btnIslem;
    }
}