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
    public partial class Satıs : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        SqlConnection con;
        public Satıs()
        {
            InitializeComponent();
        }
        private void Listele() //Datagrid listeleme işlemi için metot. 
        {
            gridSatis.DataSource = SatisIslemler.NesneSatisIslemler().Listele();
        }

        private void Satıs_Load(object sender, EventArgs e)
        {
            Listele();
        }


        private void buttonSil_Click(object sender, EventArgs e)
        {
            SatisClass silinecekSatis = new SatisClass();
            silinecekSatis = (SatisClass)gridSatis.CurrentRow.DataBoundItem;
            SatisIslemler.NesneSatisIslemler().Sil(silinecekSatis);
            Listele();
        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            Listele();
        }


        private void buttonAra_Click(object sender, EventArgs e)
        {
            SatisRaporlama st = new SatisRaporlama();
            st.ShowDialog();
        }

        private void buttonJeep_Click(object sender, EventArgs e)
        {
            JeepSatis jp = new JeepSatis();
            jp.ShowDialog();
        }

        private void buttonHatchback_Click(object sender, EventArgs e)
        {
            HatchbackSatis hb = new HatchbackSatis();
            hb.ShowDialog();
        }

        private void buttonSedan_Click(object sender, EventArgs e)
        {
            SedanSatis sd = new SedanSatis();
            sd.ShowDialog();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            SatisClass eskiSatis = new SatisClass();
            eskiSatis = (SatisClass)gridSatis.CurrentRow.DataBoundItem;
            SatisClass yeniSatis = new SatisClass();

            yeniSatis.Marka = textBoxMarka.Text;
            yeniSatis.Model = textBoxModel.Text;
            yeniSatis.Tur = textBoxTur.Text;
            yeniSatis.Plaka = textBoxPlaka.Text;
            yeniSatis.Starih = textBoxTarih.Text;
            yeniSatis.Sfiyat = textBoxFiyat.Text;

            SatisIslemler.NesneSatisIslemler().Guncelle(eskiSatis, yeniSatis);
            Listele();
        }

        private void gridSatis_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = gridSatis.CurrentRow.Cells[0].Value.ToString();
            textBoxMarka.Text = gridSatis.CurrentRow.Cells[1].Value.ToString();
            textBoxModel.Text = gridSatis.CurrentRow.Cells[2].Value.ToString();
            textBoxTur.Text = gridSatis.CurrentRow.Cells[3].Value.ToString();
            textBoxPlaka.Text = gridSatis.CurrentRow.Cells[4].Value.ToString();
            textBoxTarih.Text = gridSatis.CurrentRow.Cells[5].Value.ToString();
            textBoxFiyat.Text = gridSatis.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
