namespace Galeri_Otomasyonu
{
    partial class JeepSatis
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
            this.gridJeep = new System.Windows.Forms.DataGridView();
            this.buttonSat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSatisId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFiyat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPlaka = new System.Windows.Forms.TextBox();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.textBoxYıl = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxRenk = new System.Windows.Forms.TextBox();
            this.textBoxYakıt = new System.Windows.Forms.TextBox();
            this.textBoxAracId = new System.Windows.Forms.TextBox();
            this.textBoxTur = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gridJeep)).BeginInit();
            this.SuspendLayout();
            // 
            // gridJeep
            // 
            this.gridJeep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridJeep.Location = new System.Drawing.Point(13, 111);
            this.gridJeep.Margin = new System.Windows.Forms.Padding(4);
            this.gridJeep.Name = "gridJeep";
            this.gridJeep.Size = new System.Drawing.Size(1009, 183);
            this.gridJeep.TabIndex = 8;
            this.gridJeep.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridJeep_CellEnter);
            // 
            // buttonSat
            // 
            this.buttonSat.BackColor = System.Drawing.Color.Yellow;
            this.buttonSat.Location = new System.Drawing.Point(339, 66);
            this.buttonSat.Name = "buttonSat";
            this.buttonSat.Size = new System.Drawing.Size(126, 38);
            this.buttonSat.TabIndex = 0;
            this.buttonSat.Text = "SAT";
            this.buttonSat.UseVisualStyleBackColor = false;
            this.buttonSat.Click += new System.EventHandler(this.buttonSat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Satış no";
            // 
            // textBoxSatisId
            // 
            this.textBoxSatisId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSatisId.Location = new System.Drawing.Point(98, 31);
            this.textBoxSatisId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSatisId.Name = "textBoxSatisId";
            this.textBoxSatisId.Size = new System.Drawing.Size(132, 22);
            this.textBoxSatisId.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Fıyat";
            // 
            // textBoxFiyat
            // 
            this.textBoxFiyat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxFiyat.Location = new System.Drawing.Point(339, 29);
            this.textBoxFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFiyat.Name = "textBoxFiyat";
            this.textBoxFiyat.Size = new System.Drawing.Size(132, 22);
            this.textBoxFiyat.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Tarih";
            // 
            // textBoxPlaka
            // 
            this.textBoxPlaka.Location = new System.Drawing.Point(1025, 345);
            this.textBoxPlaka.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPlaka.Name = "textBoxPlaka";
            this.textBoxPlaka.ReadOnly = true;
            this.textBoxPlaka.Size = new System.Drawing.Size(132, 22);
            this.textBoxPlaka.TabIndex = 48;
            this.textBoxPlaka.Visible = false;
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(1025, 345);
            this.textBoxMarka.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.ReadOnly = true;
            this.textBoxMarka.Size = new System.Drawing.Size(132, 22);
            this.textBoxMarka.TabIndex = 50;
            this.textBoxMarka.Visible = false;
            // 
            // textBoxYıl
            // 
            this.textBoxYıl.Location = new System.Drawing.Point(1025, 345);
            this.textBoxYıl.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYıl.Name = "textBoxYıl";
            this.textBoxYıl.ReadOnly = true;
            this.textBoxYıl.Size = new System.Drawing.Size(132, 22);
            this.textBoxYıl.TabIndex = 51;
            this.textBoxYıl.Visible = false;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(1025, 345);
            this.textBoxModel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.ReadOnly = true;
            this.textBoxModel.Size = new System.Drawing.Size(132, 22);
            this.textBoxModel.TabIndex = 49;
            this.textBoxModel.Visible = false;
            // 
            // textBoxRenk
            // 
            this.textBoxRenk.Location = new System.Drawing.Point(1025, 345);
            this.textBoxRenk.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRenk.Name = "textBoxRenk";
            this.textBoxRenk.ReadOnly = true;
            this.textBoxRenk.Size = new System.Drawing.Size(132, 22);
            this.textBoxRenk.TabIndex = 53;
            this.textBoxRenk.Visible = false;
            // 
            // textBoxYakıt
            // 
            this.textBoxYakıt.Location = new System.Drawing.Point(1025, 345);
            this.textBoxYakıt.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYakıt.Name = "textBoxYakıt";
            this.textBoxYakıt.ReadOnly = true;
            this.textBoxYakıt.Size = new System.Drawing.Size(132, 22);
            this.textBoxYakıt.TabIndex = 55;
            this.textBoxYakıt.Visible = false;
            // 
            // textBoxAracId
            // 
            this.textBoxAracId.Location = new System.Drawing.Point(1025, 345);
            this.textBoxAracId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAracId.Name = "textBoxAracId";
            this.textBoxAracId.ReadOnly = true;
            this.textBoxAracId.Size = new System.Drawing.Size(132, 22);
            this.textBoxAracId.TabIndex = 58;
            this.textBoxAracId.Visible = false;
            this.textBoxAracId.TextChanged += new System.EventHandler(this.textBoxAracId_TextChanged);
            // 
            // textBoxTur
            // 
            this.textBoxTur.Location = new System.Drawing.Point(1025, 345);
            this.textBoxTur.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTur.Name = "textBoxTur";
            this.textBoxTur.ReadOnly = true;
            this.textBoxTur.Size = new System.Drawing.Size(132, 22);
            this.textBoxTur.TabIndex = 60;
            this.textBoxTur.Text = "Jeep";
            this.textBoxTur.Visible = false;
            this.textBoxTur.TextChanged += new System.EventHandler(this.textBoxTur_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 61;
            // 
            // JeepSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1036, 302);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxTur);
            this.Controls.Add(this.textBoxAracId);
            this.Controls.Add(this.textBoxYakıt);
            this.Controls.Add(this.textBoxRenk);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxYıl);
            this.Controls.Add(this.textBoxMarka);
            this.Controls.Add(this.textBoxPlaka);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxFiyat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSatisId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gridJeep);
            this.Controls.Add(this.buttonSat);
            this.Name = "JeepSatis";
            this.Text = "JeepSatis";
            this.Load += new System.EventHandler(this.JeepSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridJeep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridJeep;
        private System.Windows.Forms.Button buttonSat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSatisId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPlaka;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.TextBox textBoxYıl;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxRenk;
        private System.Windows.Forms.TextBox textBoxYakıt;
        private System.Windows.Forms.TextBox textBoxAracId;
        private System.Windows.Forms.TextBox textBoxTur;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}