namespace FixtureManagmentApp.Views
{
    partial class Recycle
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
            this.lblPer = new MetroFramework.Controls.MetroLabel();
            this.btnIslem = new MetroFramework.Controls.MetroButton();
            this.lblTarih = new MetroFramework.Controls.MetroLabel();
            this.dateTarih = new MetroFramework.Controls.MetroDateTime();
            this.lblUrun = new MetroFramework.Controls.MetroLabel();
            this.radioCıkar = new MetroFramework.Controls.MetroRadioButton();
            this.radioGeriGonder = new MetroFramework.Controls.MetroRadioButton();
            this.gridAtik = new MetroFramework.Controls.MetroGrid();
            this.txtPersonel = new MetroFramework.Controls.MetroTextBox();
            this.txtUrun = new MetroFramework.Controls.MetroTextBox();
            this.txtAdet = new MetroFramework.Controls.MetroTextBox();
            this.lblNot = new MetroFramework.Controls.MetroLabel();
            this.lblAdet = new MetroFramework.Controls.MetroLabel();
            this.txtNot = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtik)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Location = new System.Drawing.Point(1186, 82);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(62, 20);
            this.lblPer.TabIndex = 92;
            this.lblPer.Text = "Personel";
            // 
            // btnIslem
            // 
            this.btnIslem.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnIslem.Location = new System.Drawing.Point(1122, 562);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(225, 84);
            this.btnIslem.TabIndex = 89;
            this.btnIslem.Text = "Stoğa aktar";
            this.btnIslem.UseSelectable = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(1173, 368);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(104, 20);
            this.lblTarih.TabIndex = 88;
            this.lblTarih.Text = "Atık İslem Tarihi";
            // 
            // dateTarih
            // 
            this.dateTarih.CustomFormat = "dd.MM.yyyy";
            this.dateTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTarih.Location = new System.Drawing.Point(1122, 403);
            this.dateTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dateTarih.MaxDate = new System.DateTime(2070, 1, 1, 0, 0, 0, 0);
            this.dateTarih.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateTarih.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Size = new System.Drawing.Size(213, 30);
            this.dateTarih.TabIndex = 87;
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(1199, 154);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(40, 20);
            this.lblUrun.TabIndex = 85;
            this.lblUrun.Text = "Ürun";
            // 
            // radioCıkar
            // 
            this.radioCıkar.AutoSize = true;
            this.radioCıkar.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.radioCıkar.Location = new System.Drawing.Point(397, 24);
            this.radioCıkar.Name = "radioCıkar";
            this.radioCıkar.Size = new System.Drawing.Size(120, 25);
            this.radioCıkar.TabIndex = 83;
            this.radioCıkar.Text = "Atık yok et!";
            this.radioCıkar.UseSelectable = true;
            // 
            // radioGeriGonder
            // 
            this.radioGeriGonder.AutoSize = true;
            this.radioGeriGonder.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.radioGeriGonder.Location = new System.Drawing.Point(21, 24);
            this.radioGeriGonder.Name = "radioGeriGonder";
            this.radioGeriGonder.Size = new System.Drawing.Size(256, 25);
            this.radioGeriGonder.TabIndex = 82;
            this.radioGeriGonder.Text = "Stoğa Geri Göndeme İşlemi";
            this.radioGeriGonder.UseSelectable = true;
            this.radioGeriGonder.CheckedChanged += new System.EventHandler(this.radioGeriGonder_CheckedChanged);
            // 
            // gridAtik
            // 
            this.gridAtik.AllowUserToAddRows = false;
            this.gridAtik.AllowUserToDeleteRows = false;
            this.gridAtik.AllowUserToResizeRows = false;
            this.gridAtik.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridAtik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridAtik.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridAtik.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAtik.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAtik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAtik.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridAtik.EnableHeadersVisualStyles = false;
            this.gridAtik.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridAtik.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridAtik.Location = new System.Drawing.Point(21, 63);
            this.gridAtik.MultiSelect = false;
            this.gridAtik.Name = "gridAtik";
            this.gridAtik.ReadOnly = true;
            this.gridAtik.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAtik.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridAtik.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridAtik.RowTemplate.Height = 24;
            this.gridAtik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAtik.Size = new System.Drawing.Size(1022, 531);
            this.gridAtik.TabIndex = 79;
            this.gridAtik.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAtik_CellClick);
            // 
            // txtPersonel
            // 
            // 
            // 
            // 
            this.txtPersonel.CustomButton.Image = null;
            this.txtPersonel.CustomButton.Location = new System.Drawing.Point(185, 2);
            this.txtPersonel.CustomButton.Name = "";
            this.txtPersonel.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPersonel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPersonel.CustomButton.TabIndex = 1;
            this.txtPersonel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPersonel.CustomButton.UseSelectable = true;
            this.txtPersonel.CustomButton.Visible = false;
            this.txtPersonel.Lines = new string[0];
            this.txtPersonel.Location = new System.Drawing.Point(1122, 108);
            this.txtPersonel.MaxLength = 32767;
            this.txtPersonel.Name = "txtPersonel";
            this.txtPersonel.PasswordChar = '\0';
            this.txtPersonel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPersonel.SelectedText = "";
            this.txtPersonel.SelectionLength = 0;
            this.txtPersonel.SelectionStart = 0;
            this.txtPersonel.ShortcutsEnabled = true;
            this.txtPersonel.Size = new System.Drawing.Size(213, 30);
            this.txtPersonel.TabIndex = 93;
            this.txtPersonel.UseSelectable = true;
            this.txtPersonel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPersonel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUrun
            // 
            // 
            // 
            // 
            this.txtUrun.CustomButton.Image = null;
            this.txtUrun.CustomButton.Location = new System.Drawing.Point(185, 2);
            this.txtUrun.CustomButton.Name = "";
            this.txtUrun.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtUrun.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUrun.CustomButton.TabIndex = 1;
            this.txtUrun.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUrun.CustomButton.UseSelectable = true;
            this.txtUrun.CustomButton.Visible = false;
            this.txtUrun.Lines = new string[0];
            this.txtUrun.Location = new System.Drawing.Point(1122, 180);
            this.txtUrun.MaxLength = 32767;
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.PasswordChar = '\0';
            this.txtUrun.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrun.SelectedText = "";
            this.txtUrun.SelectionLength = 0;
            this.txtUrun.SelectionStart = 0;
            this.txtUrun.ShortcutsEnabled = true;
            this.txtUrun.Size = new System.Drawing.Size(213, 30);
            this.txtUrun.TabIndex = 94;
            this.txtUrun.UseSelectable = true;
            this.txtUrun.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUrun.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAdet
            // 
            // 
            // 
            // 
            this.txtAdet.CustomButton.Image = null;
            this.txtAdet.CustomButton.Location = new System.Drawing.Point(74, 2);
            this.txtAdet.CustomButton.Name = "";
            this.txtAdet.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAdet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdet.CustomButton.TabIndex = 1;
            this.txtAdet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdet.CustomButton.UseSelectable = true;
            this.txtAdet.CustomButton.Visible = false;
            this.txtAdet.Lines = new string[0];
            this.txtAdet.Location = new System.Drawing.Point(1175, 485);
            this.txtAdet.MaxLength = 32767;
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.PasswordChar = '\0';
            this.txtAdet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdet.SelectedText = "";
            this.txtAdet.SelectionLength = 0;
            this.txtAdet.SelectionStart = 0;
            this.txtAdet.ShortcutsEnabled = true;
            this.txtAdet.Size = new System.Drawing.Size(102, 30);
            this.txtAdet.TabIndex = 98;
            this.txtAdet.UseSelectable = true;
            this.txtAdet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.Location = new System.Drawing.Point(1138, 229);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(180, 20);
            this.lblNot.TabIndex = 96;
            this.lblNot.Text = "Atık Değerlendirmesi (NOT)";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(1208, 451);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(38, 20);
            this.lblAdet.TabIndex = 95;
            this.lblAdet.Text = "Adet";
            // 
            // txtNot
            // 
            // 
            // 
            // 
            this.txtNot.CustomButton.Image = null;
            this.txtNot.CustomButton.Location = new System.Drawing.Point(127, 2);
            this.txtNot.CustomButton.Name = "";
            this.txtNot.CustomButton.Size = new System.Drawing.Size(83, 83);
            this.txtNot.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNot.CustomButton.TabIndex = 1;
            this.txtNot.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNot.CustomButton.UseSelectable = true;
            this.txtNot.CustomButton.Visible = false;
            this.txtNot.Lines = new string[0];
            this.txtNot.Location = new System.Drawing.Point(1122, 255);
            this.txtNot.MaxLength = 32767;
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.PasswordChar = '\0';
            this.txtNot.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNot.SelectedText = "";
            this.txtNot.SelectionLength = 0;
            this.txtNot.SelectionStart = 0;
            this.txtNot.ShortcutsEnabled = true;
            this.txtNot.Size = new System.Drawing.Size(213, 88);
            this.txtNot.TabIndex = 97;
            this.txtNot.UseSelectable = true;
            this.txtNot.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNot.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Recycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 699);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.lblNot);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.txtUrun);
            this.Controls.Add(this.txtPersonel);
            this.Controls.Add(this.lblPer);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.dateTarih);
            this.Controls.Add(this.lblUrun);
            this.Controls.Add(this.radioCıkar);
            this.Controls.Add(this.radioGeriGonder);
            this.Controls.Add(this.gridAtik);
            this.Name = "Recycle";
            this.Style = MetroFramework.MetroColorStyle.White;
            ((System.ComponentModel.ISupportInitialize)(this.gridAtik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblPer;
        private MetroFramework.Controls.MetroButton btnIslem;
        private MetroFramework.Controls.MetroLabel lblTarih;
        private MetroFramework.Controls.MetroDateTime dateTarih;
        private MetroFramework.Controls.MetroLabel lblUrun;
        private MetroFramework.Controls.MetroRadioButton radioCıkar;
        private MetroFramework.Controls.MetroRadioButton radioGeriGonder;
        private MetroFramework.Controls.MetroGrid gridAtik;
        private MetroFramework.Controls.MetroTextBox txtPersonel;
        private MetroFramework.Controls.MetroTextBox txtUrun;
        private MetroFramework.Controls.MetroTextBox txtAdet;
        private MetroFramework.Controls.MetroLabel lblNot;
        private MetroFramework.Controls.MetroLabel lblAdet;
        private MetroFramework.Controls.MetroTextBox txtNot;
    }
}