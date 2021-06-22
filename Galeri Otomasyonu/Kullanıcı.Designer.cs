namespace Galeri_Otomasyonu
{
    partial class Kullanıcı
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
            this.gridKullanici = new System.Windows.Forms.DataGridView();
            this.groupBoxIsDetay = new System.Windows.Forms.GroupBox();
            this.groupBoxIsDetayEkleDuzenle = new System.Windows.Forms.GroupBox();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelDetay2 = new System.Windows.Forms.Label();
            this.labelDetay1 = new System.Windows.Forms.Label();
            this.labelIsSiraNo = new System.Windows.Forms.Label();
            this.buttonXMLAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanici)).BeginInit();
            this.groupBoxIsDetay.SuspendLayout();
            this.groupBoxIsDetayEkleDuzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridKullanici
            // 
            this.gridKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKullanici.Location = new System.Drawing.Point(24, 208);
            this.gridKullanici.Margin = new System.Windows.Forms.Padding(4);
            this.gridKullanici.Name = "gridKullanici";
            this.gridKullanici.Size = new System.Drawing.Size(1009, 183);
            this.gridKullanici.TabIndex = 7;
            this.gridKullanici.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridKullanici_CellEnter);
            // 
            // groupBoxIsDetay
            // 
            this.groupBoxIsDetay.Controls.Add(this.gridKullanici);
            this.groupBoxIsDetay.Controls.Add(this.groupBoxIsDetayEkleDuzenle);
            this.groupBoxIsDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIsDetay.Location = new System.Drawing.Point(65, 31);
            this.groupBoxIsDetay.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetay.Name = "groupBoxIsDetay";
            this.groupBoxIsDetay.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetay.Size = new System.Drawing.Size(1041, 399);
            this.groupBoxIsDetay.TabIndex = 15;
            this.groupBoxIsDetay.TabStop = false;
            this.groupBoxIsDetay.Text = "Kullanıcılar";
            // 
            // groupBoxIsDetayEkleDuzenle
            // 
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonGuncelle);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxSoyad);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label2);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxAd);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label1);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonSil);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonEkle);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxSifre);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxKullaniciAdi);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxId);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.labelDetay2);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.labelDetay1);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.labelIsSiraNo);
            this.groupBoxIsDetayEkleDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIsDetayEkleDuzenle.Location = new System.Drawing.Point(24, 31);
            this.groupBoxIsDetayEkleDuzenle.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetayEkleDuzenle.Name = "groupBoxIsDetayEkleDuzenle";
            this.groupBoxIsDetayEkleDuzenle.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetayEkleDuzenle.Size = new System.Drawing.Size(1009, 169);
            this.groupBoxIsDetayEkleDuzenle.TabIndex = 0;
            this.groupBoxIsDetayEkleDuzenle.TabStop = false;
            this.groupBoxIsDetayEkleDuzenle.Text = "Kullanıcıları Ekle ve Düzenle";
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.Orange;
            this.buttonGuncelle.Location = new System.Drawing.Point(369, 108);
            this.buttonGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(173, 44);
            this.buttonGuncelle.TabIndex = 26;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSoyad.Location = new System.Drawing.Point(644, 27);
            this.textBoxSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(132, 23);
            this.textBoxSoyad.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Soyad";
            // 
            // textBoxAd
            // 
            this.textBoxAd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAd.Location = new System.Drawing.Point(401, 30);
            this.textBoxAd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(132, 23);
            this.textBoxAd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ad";
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.Orange;
            this.buttonSil.Location = new System.Drawing.Point(563, 108);
            this.buttonSil.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(173, 44);
            this.buttonSil.TabIndex = 8;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.Orange;
            this.buttonEkle.Location = new System.Drawing.Point(159, 108);
            this.buttonEkle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(173, 44);
            this.buttonEkle.TabIndex = 6;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(401, 64);
            this.textBoxSifre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(132, 23);
            this.textBoxSifre.TabIndex = 7;
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(104, 64);
            this.textBoxKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(132, 23);
            this.textBoxKullaniciAdi.TabIndex = 6;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(103, 36);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(132, 23);
            this.textBoxId.TabIndex = 3;
            // 
            // labelDetay2
            // 
            this.labelDetay2.AutoSize = true;
            this.labelDetay2.Location = new System.Drawing.Point(335, 64);
            this.labelDetay2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetay2.Name = "labelDetay2";
            this.labelDetay2.Size = new System.Drawing.Size(37, 17);
            this.labelDetay2.TabIndex = 2;
            this.labelDetay2.Text = "Sifre";
            // 
            // labelDetay1
            // 
            this.labelDetay1.AutoSize = true;
            this.labelDetay1.Location = new System.Drawing.Point(20, 64);
            this.labelDetay1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetay1.Name = "labelDetay1";
            this.labelDetay1.Size = new System.Drawing.Size(84, 17);
            this.labelDetay1.TabIndex = 1;
            this.labelDetay1.Text = "Kullanıcı Adı";
            // 
            // labelIsSiraNo
            // 
            this.labelIsSiraNo.AutoSize = true;
            this.labelIsSiraNo.Location = new System.Drawing.Point(20, 36);
            this.labelIsSiraNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIsSiraNo.Name = "labelIsSiraNo";
            this.labelIsSiraNo.Size = new System.Drawing.Size(55, 17);
            this.labelIsSiraNo.TabIndex = 0;
            this.labelIsSiraNo.Text = "Sıra No";
            // 
            // buttonXMLAl
            // 
            this.buttonXMLAl.BackColor = System.Drawing.Color.Orange;
            this.buttonXMLAl.Location = new System.Drawing.Point(443, 438);
            this.buttonXMLAl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXMLAl.Name = "buttonXMLAl";
            this.buttonXMLAl.Size = new System.Drawing.Size(227, 28);
            this.buttonXMLAl.TabIndex = 17;
            this.buttonXMLAl.Text = "Bilgileri Al";
            this.buttonXMLAl.UseVisualStyleBackColor = false;
            this.buttonXMLAl.Click += new System.EventHandler(this.buttonXMLAl_Click);
            // 
            // Kullanıcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1170, 488);
            this.Controls.Add(this.groupBoxIsDetay);
            this.Controls.Add(this.buttonXMLAl);
            this.Name = "Kullanıcı";
            this.Text = "Kullanıcı";
            this.Load += new System.EventHandler(this.Kullanıcı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanici)).EndInit();
            this.groupBoxIsDetay.ResumeLayout(false);
            this.groupBoxIsDetayEkleDuzenle.ResumeLayout(false);
            this.groupBoxIsDetayEkleDuzenle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridKullanici;
        private System.Windows.Forms.GroupBox groupBoxIsDetay;
        private System.Windows.Forms.GroupBox groupBoxIsDetayEkleDuzenle;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelDetay2;
        private System.Windows.Forms.Label labelDetay1;
        private System.Windows.Forms.Label labelIsSiraNo;
        private System.Windows.Forms.Button buttonXMLAl;
        private System.Windows.Forms.Button buttonGuncelle;
    }
}