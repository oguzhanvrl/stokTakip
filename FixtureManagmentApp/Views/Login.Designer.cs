namespace FixtureManagmentApp.Views
{
    partial class Login
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
            this.lbSifreyiGoster = new MetroFramework.Controls.MetroLabel();
            this.lblSifre = new MetroFramework.Controls.MetroLabel();
            this.lblKullaniciAdi = new MetroFramework.Controls.MetroLabel();
            this.txtSifre = new MetroFramework.Controls.MetroTextBox();
            this.txtKullaniciAdi = new MetroFramework.Controls.MetroTextBox();
            this.btnGiris = new MetroFramework.Controls.MetroButton();
            this.lblProgram = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lbSifreyiGoster
            // 
            this.lbSifreyiGoster.AutoSize = true;
            this.lbSifreyiGoster.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbSifreyiGoster.Location = new System.Drawing.Point(567, 332);
            this.lbSifreyiGoster.Name = "lbSifreyiGoster";
            this.lbSifreyiGoster.Size = new System.Drawing.Size(26, 25);
            this.lbSifreyiGoster.TabIndex = 13;
            this.lbSifreyiGoster.Text = "O";
            this.lbSifreyiGoster.MouseEnter += new System.EventHandler(this.lbSifreyiGoster_MouseEnter);
            this.lbSifreyiGoster.MouseLeave += new System.EventHandler(this.lbSifreyiGoster_MouseLeave);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSifre.Location = new System.Drawing.Point(186, 336);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(46, 25);
            this.lblSifre.TabIndex = 11;
            this.lblSifre.Text = "Şifre";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(186, 236);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(107, 25);
            this.lblKullaniciAdi.TabIndex = 10;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // txtSifre
            // 
            // 
            // 
            // 
            this.txtSifre.CustomButton.Image = null;
            this.txtSifre.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txtSifre.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.CustomButton.Name = "";
            this.txtSifre.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSifre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSifre.CustomButton.TabIndex = 1;
            this.txtSifre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSifre.CustomButton.UseSelectable = true;
            this.txtSifre.CustomButton.Visible = false;
            this.txtSifre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSifre.Lines = new string[0];
            this.txtSifre.Location = new System.Drawing.Point(336, 332);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.MaxLength = 32767;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSifre.SelectedText = "";
            this.txtSifre.SelectionLength = 0;
            this.txtSifre.SelectionStart = 0;
            this.txtSifre.ShortcutsEnabled = false;
            this.txtSifre.Size = new System.Drawing.Size(224, 29);
            this.txtSifre.TabIndex = 9;
            this.txtSifre.UseSelectable = true;
            this.txtSifre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSifre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            // 
            // txtKullaniciAdi
            // 
            // 
            // 
            // 
            this.txtKullaniciAdi.CustomButton.Image = null;
            this.txtKullaniciAdi.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txtKullaniciAdi.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdi.CustomButton.Name = "";
            this.txtKullaniciAdi.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtKullaniciAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKullaniciAdi.CustomButton.TabIndex = 1;
            this.txtKullaniciAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKullaniciAdi.CustomButton.UseSelectable = true;
            this.txtKullaniciAdi.CustomButton.Visible = false;
            this.txtKullaniciAdi.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtKullaniciAdi.Lines = new string[0];
            this.txtKullaniciAdi.Location = new System.Drawing.Point(336, 236);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdi.MaxLength = 32767;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.PasswordChar = '\0';
            this.txtKullaniciAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKullaniciAdi.SelectedText = "";
            this.txtKullaniciAdi.SelectionLength = 0;
            this.txtKullaniciAdi.SelectionStart = 0;
            this.txtKullaniciAdi.ShortcutsEnabled = false;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(224, 29);
            this.txtKullaniciAdi.TabIndex = 8;
            this.txtKullaniciAdi.UseSelectable = true;
            this.txtKullaniciAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKullaniciAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciAdi_KeyPress);
            // 
            // btnGiris
            // 
            this.btnGiris.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnGiris.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnGiris.Location = new System.Drawing.Point(271, 476);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(250, 100);
            this.btnGiris.TabIndex = 7;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseSelectable = true;
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblProgram.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblProgram.Location = new System.Drawing.Point(247, 121);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(245, 25);
            this.lblProgram.TabIndex = 14;
            this.lblProgram.Text = "DEMİRBAŞ YÖNETİM SİSTEMİ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.lbSifreyiGoster);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.btnGiris);
            this.KeyPreview = true;
            this.Name = "Login";
            this.Text = "Giriş Yap";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbSifreyiGoster;
        private MetroFramework.Controls.MetroLabel lblSifre;
        private MetroFramework.Controls.MetroLabel lblKullaniciAdi;
        private MetroFramework.Controls.MetroTextBox txtSifre;
        private MetroFramework.Controls.MetroTextBox txtKullaniciAdi;
        private MetroFramework.Controls.MetroButton btnGiris;
        private MetroFramework.Controls.MetroLabel lblProgram;
    }
}