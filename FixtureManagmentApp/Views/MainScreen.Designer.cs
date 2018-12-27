namespace FixtureManagmentApp.Views
{
    partial class MainScreen
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
            this.mTab = new MetroFramework.Controls.MetroTabControl();
            this.SuspendLayout();
            // 
            // mTab
            // 
            this.mTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.mTab.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.mTab.ItemSize = new System.Drawing.Size(80, 34);
            this.mTab.Location = new System.Drawing.Point(20, 60);
            this.mTab.Name = "mTab";
            this.mTab.Size = new System.Drawing.Size(975, 64);
            this.mTab.TabIndex = 1;
            this.mTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTab.UseSelectable = true;
            this.mTab.SelectedIndexChanged += new System.EventHandler(this.mTab_SelectedIndexChanged);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 597);
            this.Controls.Add(this.mTab);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "MainScreen";
            this.Text = "Demirbaş Yönetim Sistemi";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainScreen_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mTab;
    }
}