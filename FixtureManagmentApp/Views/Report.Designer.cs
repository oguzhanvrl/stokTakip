namespace FixtureManagmentApp.Views
{
    partial class Report
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
            this.cmbAra = new MetroFramework.Controls.MetroComboBox();
            this.gridRapor = new MetroFramework.Controls.MetroGrid();
            this.radioBolum = new MetroFramework.Controls.MetroRadioButton();
            this.radioKisi = new MetroFramework.Controls.MetroRadioButton();
            this.btnIslem = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Location = new System.Drawing.Point(1086, 68);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(81, 20);
            this.lblPer.TabIndex = 88;
            this.lblPer.Text = "Bölüm / Kişi";
            // 
            // cmbAra
            // 
            this.cmbAra.FormattingEnabled = true;
            this.cmbAra.ItemHeight = 24;
            this.cmbAra.Location = new System.Drawing.Point(1086, 103);
            this.cmbAra.Name = "cmbAra";
            this.cmbAra.Size = new System.Drawing.Size(224, 30);
            this.cmbAra.TabIndex = 87;
            this.cmbAra.UseSelectable = true;
            this.cmbAra.SelectedIndexChanged += new System.EventHandler(this.cmbAra_SelectedIndexChanged);
            // 
            // gridRapor
            // 
            this.gridRapor.AllowUserToAddRows = false;
            this.gridRapor.AllowUserToDeleteRows = false;
            this.gridRapor.AllowUserToResizeRows = false;
            this.gridRapor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridRapor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridRapor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridRapor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRapor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridRapor.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridRapor.EnableHeadersVisualStyles = false;
            this.gridRapor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridRapor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridRapor.Location = new System.Drawing.Point(38, 146);
            this.gridRapor.MultiSelect = false;
            this.gridRapor.Name = "gridRapor";
            this.gridRapor.ReadOnly = true;
            this.gridRapor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRapor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridRapor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridRapor.RowTemplate.Height = 24;
            this.gridRapor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRapor.Size = new System.Drawing.Size(1022, 504);
            this.gridRapor.TabIndex = 79;
            // 
            // radioBolum
            // 
            this.radioBolum.AutoSize = true;
            this.radioBolum.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.radioBolum.Location = new System.Drawing.Point(218, 63);
            this.radioBolum.Name = "radioBolum";
            this.radioBolum.Size = new System.Drawing.Size(194, 25);
            this.radioBolum.TabIndex = 89;
            this.radioBolum.Text = "Bölüme göre arama";
            this.radioBolum.UseSelectable = true;
            this.radioBolum.CheckedChanged += new System.EventHandler(this.radioBolum_CheckedChanged);
            // 
            // radioKisi
            // 
            this.radioKisi.AutoSize = true;
            this.radioKisi.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.radioKisi.Location = new System.Drawing.Point(585, 63);
            this.radioKisi.Name = "radioKisi";
            this.radioKisi.Size = new System.Drawing.Size(178, 25);
            this.radioKisi.TabIndex = 90;
            this.radioKisi.Text = "Kişiye göre arama";
            this.radioKisi.UseSelectable = true;
            // 
            // btnIslem
            // 
            this.btnIslem.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnIslem.Location = new System.Drawing.Point(1084, 156);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(240, 52);
            this.btnIslem.TabIndex = 85;
            this.btnIslem.Text = "Bölüme Göre Rapor Çıktısı";
            this.btnIslem.UseSelectable = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 772);
            this.ControlBox = false;
            this.Controls.Add(this.radioKisi);
            this.Controls.Add(this.radioBolum);
            this.Controls.Add(this.lblPer);
            this.Controls.Add(this.cmbAra);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.gridRapor);
            this.Name = "Report";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.gridRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblPer;
        private MetroFramework.Controls.MetroComboBox cmbAra;
        private MetroFramework.Controls.MetroGrid gridRapor;
        private MetroFramework.Controls.MetroRadioButton radioBolum;
        private MetroFramework.Controls.MetroRadioButton radioKisi;
        private MetroFramework.Controls.MetroButton btnIslem;
    }
}