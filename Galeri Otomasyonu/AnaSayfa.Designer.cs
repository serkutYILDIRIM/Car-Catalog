namespace Galeri_Otomasyonu
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GaleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yönetimselİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otobüslerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şoförlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seferlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleSilDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oturumuKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GaleriToolStripMenuItem,
            this.yönetimselİşlemlerToolStripMenuItem,
            this.kullanıcıİşlemleriToolStripMenuItem,
            this.oturumuKapatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(823, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GaleriToolStripMenuItem
            // 
            this.GaleriToolStripMenuItem.Name = "GaleriToolStripMenuItem";
            this.GaleriToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.GaleriToolStripMenuItem.Text = "Satış";
            this.GaleriToolStripMenuItem.Click += new System.EventHandler(this.GaleriToolStripMenuItem_Click);
            // 
            // yönetimselİşlemlerToolStripMenuItem
            // 
            this.yönetimselİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otobüslerToolStripMenuItem,
            this.şoförlerToolStripMenuItem,
            this.seferlerToolStripMenuItem});
            this.yönetimselİşlemlerToolStripMenuItem.Name = "yönetimselİşlemlerToolStripMenuItem";
            this.yönetimselİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.yönetimselİşlemlerToolStripMenuItem.Text = "Araclar";
            // 
            // otobüslerToolStripMenuItem
            // 
            this.otobüslerToolStripMenuItem.Name = "otobüslerToolStripMenuItem";
            this.otobüslerToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.otobüslerToolStripMenuItem.Text = "Hatchback";
            this.otobüslerToolStripMenuItem.Click += new System.EventHandler(this.otobüslerToolStripMenuItem_Click);
            // 
            // şoförlerToolStripMenuItem
            // 
            this.şoförlerToolStripMenuItem.Name = "şoförlerToolStripMenuItem";
            this.şoförlerToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.şoförlerToolStripMenuItem.Text = "Sedan";
            this.şoförlerToolStripMenuItem.Click += new System.EventHandler(this.şoförlerToolStripMenuItem_Click);
            // 
            // seferlerToolStripMenuItem
            // 
            this.seferlerToolStripMenuItem.Name = "seferlerToolStripMenuItem";
            this.seferlerToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.seferlerToolStripMenuItem.Text = "Jeep";
            this.seferlerToolStripMenuItem.Click += new System.EventHandler(this.seferlerToolStripMenuItem_Click);
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleSilDüzenleToolStripMenuItem});
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // ekleSilDüzenleToolStripMenuItem
            // 
            this.ekleSilDüzenleToolStripMenuItem.Name = "ekleSilDüzenleToolStripMenuItem";
            this.ekleSilDüzenleToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.ekleSilDüzenleToolStripMenuItem.Text = "Ekle/Sil/Düzenle";
            this.ekleSilDüzenleToolStripMenuItem.Click += new System.EventHandler(this.ekleSilDüzenleToolStripMenuItem_Click);
            // 
            // oturumuKapatToolStripMenuItem
            // 
            this.oturumuKapatToolStripMenuItem.Name = "oturumuKapatToolStripMenuItem";
            this.oturumuKapatToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.oturumuKapatToolStripMenuItem.Text = "Oturumu Kapat";
            this.oturumuKapatToolStripMenuItem.Click += new System.EventHandler(this.oturumuKapatToolStripMenuItem_Click);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Location = new System.Drawing.Point(796, 408);
            this.lblKullanici.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(0, 17);
            this.lblKullanici.TabIndex = 9;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(823, 422);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblKullanici);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem GaleriToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem yönetimselİşlemlerToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem otobüslerToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem şoförlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seferlerToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ekleSilDüzenleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem oturumuKapatToolStripMenuItem;
        public System.Windows.Forms.Label lblKullanici;
    }
}

