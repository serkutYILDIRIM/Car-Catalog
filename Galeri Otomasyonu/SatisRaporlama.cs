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
    public partial class SatisRaporlama : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        SqlConnection con;
        public SatisRaporlama()
        {
            InitializeComponent();
        }
        private void Listele() //Datagrid listeleme işlemi için metot. 
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2PT82S1\;Initial Catalog=Galeri;Integrated Security=SSPI;");
            da = new SqlDataAdapter("Select *From satıs ", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "satıs");
            gridSatis.DataSource = ds.Tables["satıs"];
            con.Close();
        }

        private void SatisRaporlama_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dateTimePicker1_TabIndexChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2PT82S1\;Initial Catalog=Galeri;Integrated Security=SSPI;");
            da = new SqlDataAdapter("Select *From satıs where sTarih like '" + dateTimePicker1.Value.ToShortDateString() + "%'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "satıs");
            gridSatis.DataSource = ds.Tables["satıs"];
            con.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2PT82S1\;Initial Catalog=Galeri;Integrated Security=SSPI;");
            da = new SqlDataAdapter("Select *From satıs where sTarih like '" + dateTimePicker1.Value.ToShortDateString() + "%'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "satıs");
            gridSatis.DataSource = ds.Tables["satıs"];
            con.Close();
        }
    }
}
