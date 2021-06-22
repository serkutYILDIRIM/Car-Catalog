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
    public partial class Jeep : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        SqlConnection con;
        public Jeep()
        {
            InitializeComponent();
        }
       private void Listele() //Datagrid listeleme işlemi için metot. 
        {
            gridJeep.DataSource = JeepIslemler.NesneJeepIslemler().Listele();
        }

        private void Jeep_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            AracInterface yeniJeep = AracConverter.CreateConverterClass("jeep");
            
            yeniJeep.AdaracId = Convert.ToInt32(textBoxAracId.Text);
            yeniJeep.AdPlaka = textBoxPlaka.Text;
            yeniJeep.AdMarka = textBoxMarka.Text;
            yeniJeep.AdModel = textBoxModel.Text;
            yeniJeep.AdYıl = textBoxYıl.Text;
            yeniJeep.AdRenk = textBoxRenk.Text;
            yeniJeep.AdYakıt = textBoxYakıt.Text;
            JeepIslemler.NesneJeepIslemler().Ekle((JeepClass)yeniJeep);
            Listele();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            AracInterface eskiJeep = AracConverter.CreateConverterClass("jeep");
            eskiJeep = (JeepClass)gridJeep.CurrentRow.DataBoundItem;
            AracInterface yeniJeep = AracConverter.CreateConverterClass("jeep");
            
            yeniJeep.AdPlaka = textBoxPlaka.Text;
            yeniJeep.AdMarka = textBoxMarka.Text;
            yeniJeep.AdModel = textBoxModel.Text;
            yeniJeep.AdYıl = textBoxYıl.Text;
            yeniJeep.AdRenk = textBoxRenk.Text;
            yeniJeep.AdYakıt = textBoxYakıt.Text;
            /*
            yeniJeep.AracId = Convert.ToInt32(gridJeep.SelectedRows[0].Cells[0].Value);
            yeniJeep.Plaka = Convert.ToString(gridJeep.SelectedRows[0].Cells[1].Value);
            yeniJeep.Marka = Convert.ToString(gridJeep.SelectedRows[0].Cells[2].Value);
            yeniJeep.Model = Convert.ToString(gridJeep.SelectedRows[0].Cells[3].Value);
            yeniJeep.Yıl = Convert.ToString(gridJeep.SelectedRows[0].Cells[4].Value);
            yeniJeep.Renk = Convert.ToString(gridJeep.SelectedRows[0].Cells[5].Value);
            yeniJeep.Yakıt = Convert.ToString(gridJeep.SelectedRows[0].Cells[6].Value);
            */

            JeepIslemler.NesneJeepIslemler().Guncelle((JeepClass)eskiJeep, (JeepClass)yeniJeep);
            Listele();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            AracInterface silinecekJeep = AracConverter.CreateConverterClass("jeep");
            silinecekJeep = (JeepClass)gridJeep.CurrentRow.DataBoundItem;
            JeepIslemler.NesneJeepIslemler().Sil((JeepClass)silinecekJeep);
            Listele();
        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridJeep_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxAracId.Text = gridJeep.CurrentRow.Cells[0].Value.ToString();
            textBoxPlaka.Text = gridJeep.CurrentRow.Cells[1].Value.ToString();
            textBoxMarka.Text = gridJeep.CurrentRow.Cells[2].Value.ToString();
            textBoxModel.Text = gridJeep.CurrentRow.Cells[3].Value.ToString();
            textBoxYıl.Text = gridJeep.CurrentRow.Cells[4].Value.ToString();
            textBoxRenk.Text = gridJeep.CurrentRow.Cells[5].Value.ToString();
            textBoxYakıt.Text = gridJeep.CurrentRow.Cells[6].Value.ToString();
            
        }
    }
}
