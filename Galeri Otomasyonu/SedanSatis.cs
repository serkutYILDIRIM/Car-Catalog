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
    public partial class SedanSatis : Form
    {
        public SedanSatis()
        {
            InitializeComponent();
        }
        static string conString = "Server=DESKTOP-2PT82S1;Database=Galeri;Uid=sa;Password=serkut;";
        SqlConnection baglanti = new SqlConnection(conString);

        private void SedanSatis_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele() //Datagrid listeleme işlemi için metot. 
        {
            gridSedan.DataSource = SedanIslemler.NesneSedanIslemler().Listele();
        }

        private void buttonSat_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "insert into satıs(satisId,marka,model,tur,plaka,sTarih,sFiyat) values (@satisId,@marka,@model,@tur,@plaka,@sTarih,@sFiyat)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@satisId", textBoxSatisId.Text);
                komut.Parameters.AddWithValue("@marka", textBoxMarka.Text);
                komut.Parameters.AddWithValue("@model", textBoxModel.Text);
                komut.Parameters.AddWithValue("@tur", textBoxTur.Text);
                komut.Parameters.AddWithValue("@plaka", textBoxPlaka.Text);
                komut.Parameters.AddWithValue("@sTarih", dateTimePicker1.Value.ToShortDateString());
                komut.Parameters.AddWithValue("@sFiyat", textBoxFiyat.Text);
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();

                Arac ar = new Arac();
                SedanClass silinecekSedan = new AracAdapter(ar);
                silinecekSedan = (SedanClass)gridSedan.CurrentRow.DataBoundItem;
                SedanIslemler.NesneSedanIslemler().Sil(silinecekSedan);
                Listele();
                MessageBox.Show("Araç Satış İşlemi Gerçekleşti");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
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
