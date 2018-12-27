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
            this.radioGuncelle = new MetroFramework.Controls.MetroRadioButton();
            this.radioEkle = new MetroFramework.Controls.MetroRadioButton();
            this.gridUrun = new MetroFramework.Controls.MetroGrid();
            this.btnIslem = new MetroFramework.Controls.MetroButton();
            this.lblUrunOzellikleri = new MetroFramework.Controls.MetroLabel();
            this.lblUrunTuru = new MetroFramework.Controls.MetroLabel();
            this.txtUrunOzellik = new MetroFramework.Controls.MetroTextBox();
            this.txtYeniUrunTuru = new MetroFramework.Controls.MetroTextBox();
            this.cmbUrunTuru = new MetroFramework.Controls.MetroComboBox();
            this.txtUrunAdi = new MetroFramework.Controls.MetroTextBox();
            this.cbYeniUrunTuru = new MetroFramework.Controls.MetroCheckBox();
            this.lblUrunAdi = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // radioGuncelle
            // 
            this.radioGuncelle.AutoSize = true;
            this.radioGuncelle.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.radioGuncelle.Location = new System.Drawing.Point(192, 31);
            this.radioGuncelle.Name = "radioGuncelle";
            this.radioGuncelle.Size = new System.Drawing.Size(149, 25);
            this.radioGuncelle.TabIndex = 15;
            this.radioGuncelle.Text = "Ürün Güncelle";
            this.radioGuncelle.UseSelectable = true;
            // 
            // radioEkle
            // 
            this.radioEkle.AutoSize = true;
            this.radioEkle.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.radioEkle.Location = new System.Drawing.Point(25, 31);
            this.radioEkle.Name = "radioEkle";
            this.radioEkle.Size = new System.Drawing.Size(109, 25);
            this.radioEkle.TabIndex = 14;
            this.radioEkle.Text = "Ürün Ekle";
            this.radioEkle.UseSelectable = true;
            this.radioEkle.CheckedChanged += new System.EventHandler(this.radioEkle_CheckedChanged);
            // 
            // gridUrun
            // 
            this.gridUrun.AllowUserToAddRows = false;
            this.gridUrun.AllowUserToDeleteRows = false;
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
            this.gridUrun.Location = new System.Drawing.Point(515, 265);
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
            this.gridUrun.Size = new System.Drawing.Size(795, 512);
            this.gridUrun.TabIndex = 16;
            this.gridUrun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUrun_CellClick);
            // 
            // btnIslem
            // 
            this.btnIslem.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnIslem.Location = new System.Drawing.Point(1119, 180);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(159, 56);
            this.btnIslem.TabIndex = 26;
            this.btnIslem.Text = "Ekle";
            this.btnIslem.UseSelectable = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click_1);
            // 
            // lblUrunOzellikleri
            // 
            this.lblUrunOzellikleri.AutoSize = true;
            this.lblUrunOzellikleri.Location = new System.Drawing.Point(976, 98);
            this.lblUrunOzellikleri.Name = "lblUrunOzellikleri";
            this.lblUrunOzellikleri.Size = new System.Drawing.Size(105, 20);
            this.lblUrunOzellikleri.TabIndex = 25;
            this.lblUrunOzellikleri.Text = "Ürün Özellikleri";
            // 
            // lblUrunTuru
            // 
            this.lblUrunTuru.AutoSize = true;
            this.lblUrunTuru.Location = new System.Drawing.Point(530, 180);
            this.lblUrunTuru.Name = "lblUrunTuru";
            this.lblUrunTuru.Size = new System.Drawing.Size(71, 20);
            this.lblUrunTuru.TabIndex = 24;
            this.lblUrunTuru.Text = "Ürün Türü";
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
            this.txtUrunOzellik.Location = new System.Drawing.Point(1119, 98);
            this.txtUrunOzellik.MaxLength = 32767;
            this.txtUrunOzellik.Name = "txtUrunOzellik";
            this.txtUrunOzellik.PasswordChar = '\0';
            this.txtUrunOzellik.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrunOzellik.SelectedText = "";
            this.txtUrunOzellik.SelectionLength = 0;
            this.txtUrunOzellik.SelectionStart = 0;
            this.txtUrunOzellik.ShortcutsEnabled = false;
            this.txtUrunOzellik.Size = new System.Drawing.Size(261, 30);
            this.txtUrunOzellik.TabIndex = 23;
            this.txtUrunOzellik.UseSelectable = true;
            this.txtUrunOzellik.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUrunOzellik.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUrunOzellik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunOzellik_KeyPress);
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
            this.txtYeniUrunTuru.Location = new System.Drawing.Point(673, 180);
            this.txtYeniUrunTuru.MaxLength = 32767;
            this.txtYeniUrunTuru.Name = "txtYeniUrunTuru";
            this.txtYeniUrunTuru.PasswordChar = '\0';
            this.txtYeniUrunTuru.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtYeniUrunTuru.SelectedText = "";
            this.txtYeniUrunTuru.SelectionLength = 0;
            this.txtYeniUrunTuru.SelectionStart = 0;
            this.txtYeniUrunTuru.ShortcutsEnabled = false;
            this.txtYeniUrunTuru.Size = new System.Drawing.Size(261, 30);
            this.txtYeniUrunTuru.TabIndex = 22;
            this.txtYeniUrunTuru.UseSelectable = true;
            this.txtYeniUrunTuru.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtYeniUrunTuru.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtYeniUrunTuru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYeniUrunTuru_KeyPress);
            // 
            // cmbUrunTuru
            // 
            this.cmbUrunTuru.FormattingEnabled = true;
            this.cmbUrunTuru.ItemHeight = 24;
            this.cmbUrunTuru.Location = new System.Drawing.Point(673, 180);
            this.cmbUrunTuru.Name = "cmbUrunTuru";
            this.cmbUrunTuru.Size = new System.Drawing.Size(261, 30);
            this.cmbUrunTuru.TabIndex = 21;
            this.cmbUrunTuru.UseSelectable = true;
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
            this.txtUrunAdi.Location = new System.Drawing.Point(673, 95);
            this.txtUrunAdi.MaxLength = 32767;
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.PasswordChar = '\0';
            this.txtUrunAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrunAdi.SelectedText = "";
            this.txtUrunAdi.SelectionLength = 0;
            this.txtUrunAdi.SelectionStart = 0;
            this.txtUrunAdi.ShortcutsEnabled = false;
            this.txtUrunAdi.Size = new System.Drawing.Size(261, 30);
            this.txtUrunAdi.TabIndex = 20;
            this.txtUrunAdi.UseSelectable = true;
            this.txtUrunAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUrunAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUrunAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunAdi_KeyPress);
            // 
            // cbYeniUrunTuru
            // 
            this.cbYeniUrunTuru.AutoSize = true;
            this.cbYeniUrunTuru.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cbYeniUrunTuru.Location = new System.Drawing.Point(673, 149);
            this.cbYeniUrunTuru.Name = "cbYeniUrunTuru";
            this.cbYeniUrunTuru.Size = new System.Drawing.Size(154, 25);
            this.cbYeniUrunTuru.TabIndex = 19;
            this.cbYeniUrunTuru.Text = "Yeni Ürün Türü";
            this.cbYeniUrunTuru.UseSelectable = true;
            this.cbYeniUrunTuru.CheckedChanged += new System.EventHandler(this.cbYeniUrunTuru_CheckedChanged_1);
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(530, 98);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(64, 20);
            this.lblUrunAdi.TabIndex = 18;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 800);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.lblUrunOzellikleri);
            this.Controls.Add(this.lblUrunTuru);
            this.Controls.Add(this.txtUrunOzellik);
            this.Controls.Add(this.txtYeniUrunTuru);
            this.Controls.Add(this.cmbUrunTuru);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.cbYeniUrunTuru);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.gridUrun);
            this.Controls.Add(this.radioGuncelle);
            this.Controls.Add(this.radioEkle);
            this.Name = "Product";
            this.Style = MetroFramework.MetroColorStyle.White;
            ((System.ComponentModel.ISupportInitialize)(this.gridUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroRadioButton radioGuncelle;
        private MetroFramework.Controls.MetroRadioButton radioEkle;
        private MetroFramework.Controls.MetroGrid gridUrun;
        private MetroFramework.Controls.MetroButton btnIslem;
        private MetroFramework.Controls.MetroLabel lblUrunOzellikleri;
        private MetroFramework.Controls.MetroLabel lblUrunTuru;
        private MetroFramework.Controls.MetroTextBox txtUrunOzellik;
        private MetroFramework.Controls.MetroTextBox txtYeniUrunTuru;
        private MetroFramework.Controls.MetroComboBox cmbUrunTuru;
        private MetroFramework.Controls.MetroTextBox txtUrunAdi;
        private MetroFramework.Controls.MetroCheckBox cbYeniUrunTuru;
        private MetroFramework.Controls.MetroLabel lblUrunAdi;
    }
}