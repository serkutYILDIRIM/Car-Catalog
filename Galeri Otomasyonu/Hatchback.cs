using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Galeri_Otomasyonu
{
    public partial class Hatchback : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        SqlConnection con;
        public Hatchback()
        {
            InitializeComponent();
        }
        private void Listele() //Datagrid listeleme işlemi için metot. 
        {
            gridHatchback.DataSource = HatchbackIslemler.NesneHatchbackIslemler().Listele();
        }

        private void Hatchback_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            AracInterface yeniHatchback = AracConverter.CreateConverterClass("hatchback");

            yeniHatchback.AdaracId = Convert.ToInt32(textBoxAracId.Text);
            yeniHatchback.AdPlaka = textBoxPlaka.Text;
            yeniHatchback.AdMarka = textBoxMarka.Text;
            yeniHatchback.AdModel = textBoxModel.Text;
            yeniHatchback.AdYıl = textBoxYıl.Text;
            yeniHatchback.AdRenk = textBoxRenk.Text;
            yeniHatchback.AdYakıt = textBoxYakıt.Text;
            HatchbackIslemler.NesneHatchbackIslemler().Ekle((HatchbackClass)yeniHatchback);
            Listele();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            AracInterface eskiHatchback = AracConverter.CreateConverterClass("hatchback");
            eskiHatchback = (HatchbackClass)gridHatchback.CurrentRow.DataBoundItem;
            AracInterface yeniHatchback = AracConverter.CreateConverterClass("hatchback");

            yeniHatchback.AdPlaka = textBoxPlaka.Text;
            yeniHatchback.AdMarka = textBoxMarka.Text;
            yeniHatchback.AdModel = textBoxModel.Text;
            yeniHatchback.AdYıl = textBoxYıl.Text;
            yeniHatchback.AdRenk = textBoxRenk.Text;
            yeniHatchback.AdYakıt = textBoxYakıt.Text;

            HatchbackIslemler.NesneHatchbackIslemler().Guncelle((HatchbackClass)eskiHatchback,(HatchbackClass)yeniHatchback);
            Listele();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            AracInterface silinecekHatchback = AracConverter.CreateConverterClass("hatchback");
            silinecekHatchback = (HatchbackClass)gridHatchback.CurrentRow.DataBoundItem;
            HatchbackIslemler.NesneHatchbackIslemler().Sil((HatchbackClass)silinecekHatchback);
            Listele();
        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridHatchback_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxAracId.Text = gridHatchback.CurrentRow.Cells[0].Value.ToString();
            textBoxPlaka.Text = gridHatchback.CurrentRow.Cells[1].Value.ToString();
            textBoxMarka.Text = gridHatchback.CurrentRow.Cells[2].Value.ToString();
            textBoxModel.Text = gridHatchback.CurrentRow.Cells[3].Value.ToString();
            textBoxYıl.Text = gridHatchback.CurrentRow.Cells[4].Value.ToString();
            textBoxRenk.Text = gridHatchback.CurrentRow.Cells[5].Value.ToString();
            textBoxYakıt.Text = gridHatchback.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
