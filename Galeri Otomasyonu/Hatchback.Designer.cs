namespace Galeri_Otomasyonu
{
    partial class Hatchback
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
            this.gridHatchback = new System.Windows.Forms.DataGridView();
            this.groupBoxIsDetay = new System.Windows.Forms.GroupBox();
            this.groupBoxIsDetayEkleDuzenle = new System.Windows.Forms.GroupBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxPlaka = new System.Windows.Forms.TextBox();
            this.textBoxAracId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.textBoxYakıt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRenk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textBoxYıl = new System.Windows.Forms.TextBox();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.labelDetay2 = new System.Windows.Forms.Label();
            this.labelDetay1 = new System.Windows.Forms.Label();
            this.labelIsSiraNo = new System.Windows.Forms.Label();
            this.buttonXMLAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridHatchback)).BeginInit();
            this.groupBoxIsDetay.SuspendLayout();
            this.groupBoxIsDetayEkleDuzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridHatchback
            // 
            this.gridHatchback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHatchback.Location = new System.Drawing.Point(24, 208);
            this.gridHatchback.Margin = new System.Windows.Forms.Padding(4);
            this.gridHatchback.Name = "gridHatchback";
            this.gridHatchback.Size = new System.Drawing.Size(1009, 183);
            this.gridHatchback.TabIndex = 7;
            this.gridHatchback.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHatchback_CellEnter);
            // 
            // groupBoxIsDetay
            // 
            this.groupBoxIsDetay.Controls.Add(this.gridHatchback);
            this.groupBoxIsDetay.Controls.Add(this.groupBoxIsDetayEkleDuzenle);
            this.groupBoxIsDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIsDetay.Location = new System.Drawing.Point(135, 33);
            this.groupBoxIsDetay.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetay.Name = "groupBoxIsDetay";
            this.groupBoxIsDetay.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetay.Size = new System.Drawing.Size(1041, 399);
            this.groupBoxIsDetay.TabIndex = 15;
            this.groupBoxIsDetay.TabStop = false;
            this.groupBoxIsDetay.Text = "Hatchback";
            // 
            // groupBoxIsDetayEkleDuzenle
            // 
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxModel);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxPlaka);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxAracId);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label4);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonGuncelle);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxYakıt);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label3);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxRenk);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label2);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label1);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonSil);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonEkle);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxYıl);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxMarka);
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
            this.groupBoxIsDetayEkleDuzenle.Text = "Araç Ekle ve Düzenle";
            // 
            // textBoxModel
            // 
            this.textBoxModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxModel.Location = new System.Drawing.Point(401, 27);
            this.textBoxModel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(132, 23);
            this.textBoxModel.TabIndex = 28;
            // 
            // textBoxPlaka
            // 
            this.textBoxPlaka.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPlaka.Location = new System.Drawing.Point(104, 36);
            this.textBoxPlaka.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPlaka.Name = "textBoxPlaka";
            this.textBoxPlaka.Size = new System.Drawing.Size(132, 23);
            this.textBoxPlaka.TabIndex = 27;
            // 
            // textBoxAracId
            // 
            this.textBoxAracId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAracId.Location = new System.Drawing.Point(869, 24);
            this.textBoxAracId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAracId.Name = "textBoxAracId";
            this.textBoxAracId.Size = new System.Drawing.Size(132, 23);
            this.textBoxAracId.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(786, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Arac No";
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.Gold;
            this.buttonGuncelle.Location = new System.Drawing.Point(392, 108);
            this.buttonGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(173, 44);
            this.buttonGuncelle.TabIndex = 24;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // textBoxYakıt
            // 
            this.textBoxYakıt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxYakıt.Location = new System.Drawing.Point(640, 64);
            this.textBoxYakıt.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYakıt.Name = "textBoxYakıt";
            this.textBoxYakıt.Size = new System.Drawing.Size(132, 23);
            this.textBoxYakıt.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Yakıt";
            // 
            // textBoxRenk
            // 
            this.textBoxRenk.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxRenk.Location = new System.Drawing.Point(640, 27);
            this.textBoxRenk.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRenk.Name = "textBoxRenk";
            this.textBoxRenk.Size = new System.Drawing.Size(132, 23);
            this.textBoxRenk.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Renk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Model";
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.Gold;
            this.buttonSil.Location = new System.Drawing.Point(614, 108);
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
            this.buttonEkle.BackColor = System.Drawing.Color.Gold;
            this.buttonEkle.Location = new System.Drawing.Point(159, 108);
            this.buttonEkle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(173, 44);
            this.buttonEkle.TabIndex = 6;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // textBoxYıl
            // 
            this.textBoxYıl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxYıl.Location = new System.Drawing.Point(401, 64);
            this.textBoxYıl.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYıl.Name = "textBoxYıl";
            this.textBoxYıl.Size = new System.Drawing.Size(132, 23);
            this.textBoxYıl.TabIndex = 7;
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxMarka.Location = new System.Drawing.Point(104, 64);
            this.textBoxMarka.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(132, 23);
            this.textBoxMarka.TabIndex = 6;
            // 
            // labelDetay2
            // 
            this.labelDetay2.AutoSize = true;
            this.labelDetay2.Location = new System.Drawing.Point(335, 64);
            this.labelDetay2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetay2.Name = "labelDetay2";
            this.labelDetay2.Size = new System.Drawing.Size(23, 17);
            this.labelDetay2.TabIndex = 2;
            this.labelDetay2.Text = "Yıl";
            // 
            // labelDetay1
            // 
            this.labelDetay1.AutoSize = true;
            this.labelDetay1.Location = new System.Drawing.Point(20, 64);
            this.labelDetay1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetay1.Name = "labelDetay1";
            this.labelDetay1.Size = new System.Drawing.Size(47, 17);
            this.labelDetay1.TabIndex = 1;
            this.labelDetay1.Text = "Marka";
            // 
            // labelIsSiraNo
            // 
            this.labelIsSiraNo.AutoSize = true;
            this.labelIsSiraNo.Location = new System.Drawing.Point(20, 36);
            this.labelIsSiraNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIsSiraNo.Name = "labelIsSiraNo";
            this.labelIsSiraNo.Size = new System.Drawing.Size(43, 17);
            this.labelIsSiraNo.TabIndex = 0;
            this.labelIsSiraNo.Text = "Plaka";
            // 
            // buttonXMLAl
            // 
            this.buttonXMLAl.BackColor = System.Drawing.Color.Gold;
            this.buttonXMLAl.Location = new System.Drawing.Point(531, 440);
            this.buttonXMLAl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXMLAl.Name = "buttonXMLAl";
            this.buttonXMLAl.Size = new System.Drawing.Size(227, 28);
            this.buttonXMLAl.TabIndex = 17;
            this.buttonXMLAl.Text = "Bilgileri Al";
            this.buttonXMLAl.UseVisualStyleBackColor = false;
            this.buttonXMLAl.Click += new System.EventHandler(this.buttonXMLAl_Click);
            // 
            // Hatchback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1310, 492);
            this.Controls.Add(this.groupBoxIsDetay);
            this.Controls.Add(this.buttonXMLAl);
            this.Name = "Hatchback";
            this.Text = "Hatchback";
            this.Load += new System.EventHandler(this.Hatchback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHatchback)).EndInit();
            this.groupBoxIsDetay.ResumeLayout(false);
            this.groupBoxIsDetayEkleDuzenle.ResumeLayout(false);
            this.groupBoxIsDetayEkleDuzenle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridHatchback;
        private System.Windows.Forms.GroupBox groupBoxIsDetay;
        private System.Windows.Forms.GroupBox groupBoxIsDetayEkleDuzenle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.TextBox textBoxYıl;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.Label labelDetay2;
        private System.Windows.Forms.Label labelDetay1;
        private System.Windows.Forms.Label labelIsSiraNo;
        private System.Windows.Forms.Button buttonXMLAl;
        private System.Windows.Forms.TextBox textBoxYakıt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRenk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.TextBox textBoxAracId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPlaka;
        private System.Windows.Forms.TextBox textBoxModel;
    }
}