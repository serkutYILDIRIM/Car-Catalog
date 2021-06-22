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
    public partial class Sedan : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        SqlConnection con;
        public Sedan()
        {
            InitializeComponent();
        }
       private void Listele() //Datagrid listeleme işlemi için metot. 
        {
            gridSedan.DataSource = SedanIslemler.NesneSedanIslemler().Listele();
        }

        private void Sedan_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            Arac ar = new Arac();
            SedanClass yeniSedan = new AracAdapter(ar);

            yeniSedan.AdaracId = Convert.ToInt32(textBoxAracId.Text);
            yeniSedan.AdPlaka = textBoxPlaka.Text;
            yeniSedan.AdMarka = textBoxMarka.Text;
            yeniSedan.AdModel = textBoxModel.Text;
            yeniSedan.AdYıl = textBoxYıl.Text;
            yeniSedan.AdRenk = textBoxRenk.Text;
            yeniSedan.AdYakıt = textBoxYakıt.Text;
            SedanIslemler.NesneSedanIslemler().Ekle(yeniSedan);
            Listele();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            Arac ar = new Arac();
            SedanClass eskiSedan = new AracAdapter(ar);
            eskiSedan = (SedanClass)gridSedan.CurrentRow.DataBoundItem;
            SedanClass yeniSedan = new AracAdapter(ar);

            yeniSedan.AdPlaka = textBoxPlaka.Text;
            yeniSedan.AdMarka = textBoxMarka.Text;
            yeniSedan.AdModel = textBoxModel.Text;
            yeniSedan.AdYıl = textBoxYıl.Text;
            yeniSedan.AdRenk = textBoxRenk.Text;
            yeniSedan.AdYakıt = textBoxYakıt.Text;

            SedanIslemler.NesneSedanIslemler().Guncelle(eskiSedan, yeniSedan);
            Listele();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            Arac ar = new Arac();
            SedanClass silinecekSedan = new AracAdapter(ar);
            silinecekSedan = (SedanClass)gridSedan.CurrentRow.DataBoundItem;
            SedanIslemler.NesneSedanIslemler().Sil(silinecekSedan);
            Listele();
        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridSedan_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxAracId.Text = gridSedan.CurrentRow.Cells[0].Value.ToString();
            textBoxPlaka.Text = gridSedan.CurrentRow.Cells[1].Value.ToString();
            textBoxMarka.Text = gridSedan.CurrentRow.Cells[2].Value.ToString();
            textBoxModel.Text = gridSedan.CurrentRow.Cells[3].Value.ToString();
            textBoxYıl.Text = gridSedan.CurrentRow.Cells[4].Value.ToString();
            textBoxRenk.Text = gridSedan.CurrentRow.Cells[5].Value.ToString();
            textBoxYakıt.Text = gridSedan.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
