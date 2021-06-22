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
    public partial class Kullanıcı : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        SqlConnection con;
        public Kullanıcı()
        {
            InitializeComponent();
        }
       private void Listele() //Datagrid listeleme işlemi için metot. 
        {
            gridKullanici.DataSource = KullaniciIslemler.NesneKullaniciIslemler().Listele();
        }

        private void Kullanıcı_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            KullaniciClass yeniKullanici = new KullaniciClass();

            yeniKullanici.Id = Convert.ToInt32(textBoxId.Text);
            yeniKullanici.Ad = textBoxAd.Text;
            yeniKullanici.Soyad = textBoxSoyad.Text;
            yeniKullanici.KullaniciAdi = textBoxKullaniciAdi.Text;
            yeniKullanici.Sifre = textBoxSifre.Text;
            KullaniciIslemler.NesneKullaniciIslemler().Ekle(yeniKullanici);
            Listele();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            KullaniciClass eskiKullanici = new KullaniciClass();
            eskiKullanici = (KullaniciClass)gridKullanici.CurrentRow.DataBoundItem;
            KullaniciClass yeniKullanici = new KullaniciClass();

            yeniKullanici.Ad = textBoxAd.Text;
            yeniKullanici.Soyad = textBoxSoyad.Text;
            yeniKullanici.KullaniciAdi = textBoxKullaniciAdi.Text;
            yeniKullanici.Sifre = textBoxSifre.Text;;

            KullaniciIslemler.NesneKullaniciIslemler().Guncelle(eskiKullanici, yeniKullanici);
            Listele();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            KullaniciClass silinecekKullanici = new KullaniciClass();
            silinecekKullanici = (KullaniciClass)gridKullanici.CurrentRow.DataBoundItem;
            KullaniciIslemler.NesneKullaniciIslemler().Sil(silinecekKullanici);
            Listele();
        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridKullanici_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = gridKullanici.CurrentRow.Cells[0].Value.ToString();
            textBoxAd.Text = gridKullanici.CurrentRow.Cells[2].Value.ToString();
            textBoxSoyad.Text = gridKullanici.CurrentRow.Cells[3].Value.ToString();
            textBoxKullaniciAdi.Text = gridKullanici.CurrentRow.Cells[1].Value.ToString();
            textBoxSifre.Text = gridKullanici.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
