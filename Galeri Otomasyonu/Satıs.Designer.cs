namespace Galeri_Otomasyonu
{
    partial class Satıs
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
            this.gridSatis = new System.Windows.Forms.DataGridView();
            this.groupBoxIsDetay = new System.Windows.Forms.GroupBox();
            this.groupBoxIsDetayEkleDuzenle = new System.Windows.Forms.GroupBox();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSedan = new System.Windows.Forms.Button();
            this.buttonHatchback = new System.Windows.Forms.Button();
            this.buttonJeep = new System.Windows.Forms.Button();
            this.buttonAra = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonXMLAl = new System.Windows.Forms.Button();
            this.textBoxTarih = new System.Windows.Forms.TextBox();
            this.textBoxTur = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.textBoxPlaka = new System.Windows.Forms.TextBox();
            this.textBoxFiyat = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSatis)).BeginInit();
            this.groupBoxIsDetay.SuspendLayout();
            this.groupBoxIsDetayEkleDuzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSatis
            // 
            this.gridSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSatis.Location = new System.Drawing.Point(24, 177);
            this.gridSatis.Margin = new System.Windows.Forms.Padding(4);
            this.gridSatis.Name = "gridSatis";
            this.gridSatis.Size = new System.Drawing.Size(1005, 226);
            this.gridSatis.TabIndex = 7;
            this.gridSatis.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSatis_CellEnter);
            // 
            // groupBoxIsDetay
            // 
            this.groupBoxIsDetay.Controls.Add(this.gridSatis);
            this.groupBoxIsDetay.Controls.Add(this.groupBoxIsDetayEkleDuzenle);
            this.groupBoxIsDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIsDetay.Location = new System.Drawing.Point(57, 31);
            this.groupBoxIsDetay.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetay.Name = "groupBoxIsDetay";
            this.groupBoxIsDetay.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetay.Size = new System.Drawing.Size(1054, 426);
            this.groupBoxIsDetay.TabIndex = 21;
            this.groupBoxIsDetay.TabStop = false;
            this.groupBoxIsDetay.Text = "Satış Ekranı";
            // 
            // groupBoxIsDetayEkleDuzenle
            // 
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonGuncelle);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonSedan);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonHatchback);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonJeep);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonAra);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonSil);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonXMLAl);
            this.groupBoxIsDetayEkleDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIsDetayEkleDuzenle.Location = new System.Drawing.Point(24, 31);
            this.groupBoxIsDetayEkleDuzenle.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetayEkleDuzenle.Name = "groupBoxIsDetayEkleDuzenle";
            this.groupBoxIsDetayEkleDuzenle.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetayEkleDuzenle.Size = new System.Drawing.Size(1005, 138);
            this.groupBoxIsDetayEkleDuzenle.TabIndex = 0;
            this.groupBoxIsDetayEkleDuzenle.TabStop = false;
            this.groupBoxIsDetayEkleDuzenle.Text = "Araç Satış";
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.Yellow;
            this.buttonGuncelle.Location = new System.Drawing.Point(585, 89);
            this.buttonGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(113, 37);
            this.buttonGuncelle.TabIndex = 37;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSedan
            // 
            this.buttonSedan.BackColor = System.Drawing.Color.Yellow;
            this.buttonSedan.Location = new System.Drawing.Point(330, 40);
            this.buttonSedan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSedan.Name = "buttonSedan";
            this.buttonSedan.Size = new System.Drawing.Size(113, 42);
            this.buttonSedan.TabIndex = 30;
            this.buttonSedan.Text = "SEDAN";
            this.buttonSedan.UseVisualStyleBackColor = false;
            this.buttonSedan.Click += new System.EventHandler(this.buttonSedan_Click);
            // 
            // buttonHatchback
            // 
            this.buttonHatchback.BackColor = System.Drawing.Color.Yellow;
            this.buttonHatchback.Location = new System.Drawing.Point(209, 40);
            this.buttonHatchback.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHatchback.Name = "buttonHatchback";
            this.buttonHatchback.Size = new System.Drawing.Size(113, 42);
            this.buttonHatchback.TabIndex = 29;
            this.buttonHatchback.Text = "HATCHBACK";
            this.buttonHatchback.UseVisualStyleBackColor = false;
            this.buttonHatchback.Click += new System.EventHandler(this.buttonHatchback_Click);
            // 
            // buttonJeep
            // 
            this.buttonJeep.BackColor = System.Drawing.Color.Yellow;
            this.buttonJeep.Location = new System.Drawing.Point(79, 40);
            this.buttonJeep.Margin = new System.Windows.Forms.Padding(4);
            this.buttonJeep.Name = "buttonJeep";
            this.buttonJeep.Size = new System.Drawing.Size(113, 42);
            this.buttonJeep.TabIndex = 28;
            this.buttonJeep.Text = "JEEP";
            this.buttonJeep.UseVisualStyleBackColor = false;
            this.buttonJeep.Click += new System.EventHandler(this.buttonJeep_Click);
            // 
            // buttonAra
            // 
            this.buttonAra.BackColor = System.Drawing.Color.Yellow;
            this.buttonAra.Location = new System.Drawing.Point(724, 89);
            this.buttonAra.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(112, 37);
            this.buttonAra.TabIndex = 27;
            this.buttonAra.Text = "Raporlama";
            this.buttonAra.UseVisualStyleBackColor = false;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.Yellow;
            this.buttonSil.Location = new System.Drawing.Point(724, 40);
            this.buttonSil.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(112, 41);
            this.buttonSil.TabIndex = 25;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonXMLAl
            // 
            this.buttonXMLAl.BackColor = System.Drawing.Color.Yellow;
            this.buttonXMLAl.Location = new System.Drawing.Point(585, 40);
            this.buttonXMLAl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXMLAl.Name = "buttonXMLAl";
            this.buttonXMLAl.Size = new System.Drawing.Size(113, 36);
            this.buttonXMLAl.TabIndex = 23;
            this.buttonXMLAl.Text = "Bilgileri Al";
            this.buttonXMLAl.UseVisualStyleBackColor = false;
            this.buttonXMLAl.Click += new System.EventHandler(this.buttonXMLAl_Click);
            // 
            // textBoxTarih
            // 
            this.textBoxTarih.Location = new System.Drawing.Point(1218, 473);
            this.textBoxTarih.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTarih.Name = "textBoxTarih";
            this.textBoxTarih.ReadOnly = true;
            this.textBoxTarih.Size = new System.Drawing.Size(132, 22);
            this.textBoxTarih.TabIndex = 38;
            this.textBoxTarih.Visible = false;
            // 
            // textBoxTur
            // 
            this.textBoxTur.Location = new System.Drawing.Point(1218, 473);
            this.textBoxTur.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTur.Name = "textBoxTur";
            this.textBoxTur.ReadOnly = true;
            this.textBoxTur.Size = new System.Drawing.Size(132, 22);
            this.textBoxTur.TabIndex = 36;
            this.textBoxTur.Visible = false;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(1218, 473);
            this.textBoxModel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.ReadOnly = true;
            this.textBoxModel.Size = new System.Drawing.Size(132, 22);
            this.textBoxModel.TabIndex = 35;
            this.textBoxModel.Visible = false;
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(1218, 472);
            this.textBoxMarka.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.ReadOnly = true;
            this.textBoxMarka.Size = new System.Drawing.Size(132, 22);
            this.textBoxMarka.TabIndex = 34;
            this.textBoxMarka.Visible = false;
            // 
            // textBoxPlaka
            // 
            this.textBoxPlaka.Location = new System.Drawing.Point(1218, 473);
            this.textBoxPlaka.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPlaka.Name = "textBoxPlaka";
            this.textBoxPlaka.ReadOnly = true;
            this.textBoxPlaka.Size = new System.Drawing.Size(132, 22);
            this.textBoxPlaka.TabIndex = 33;
            this.textBoxPlaka.Visible = false;
            // 
            // textBoxFiyat
            // 
            this.textBoxFiyat.Location = new System.Drawing.Point(1218, 473);
            this.textBoxFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFiyat.Name = "textBoxFiyat";
            this.textBoxFiyat.ReadOnly = true;
            this.textBoxFiyat.Size = new System.Drawing.Size(132, 22);
            this.textBoxFiyat.TabIndex = 32;
            this.textBoxFiyat.Visible = false;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(1218, 473);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(132, 22);
            this.textBoxId.TabIndex = 31;
            this.textBoxId.Visible = false;
            // 
            // Satıs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1134, 467);
            this.Controls.Add(this.textBoxTarih);
            this.Controls.Add(this.textBoxMarka);
            this.Controls.Add(this.textBoxTur);
            this.Controls.Add(this.groupBoxIsDetay);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxFiyat);
            this.Controls.Add(this.textBoxPlaka);
            this.Name = "Satıs";
            this.Text = "Satıs";
            this.Load += new System.EventHandler(this.Satıs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSatis)).EndInit();
            this.groupBoxIsDetay.ResumeLayout(false);
            this.groupBoxIsDetayEkleDuzenle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSatis;
        private System.Windows.Forms.GroupBox groupBoxIsDetay;
        private System.Windows.Forms.Button buttonXMLAl;
        private System.Windows.Forms.GroupBox groupBoxIsDetayEkleDuzenle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.Button buttonSedan;
        private System.Windows.Forms.Button buttonHatchback;
        private System.Windows.Forms.Button buttonJeep;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.TextBox textBoxTarih;
        private System.Windows.Forms.TextBox textBoxTur;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.TextBox textBoxPlaka;
        private System.Windows.Forms.TextBox textBoxFiyat;
        private System.Windows.Forms.TextBox textBoxId;
    }
}