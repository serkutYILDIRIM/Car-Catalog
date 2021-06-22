using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Galeri_Otomasyonu
{
    public class Baglanti
    {
        public static SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-2PT82S1\;Initial Catalog=Galeri;Integrated Security=SSPI;");
            baglan.Open();
            return baglan;
        }
        public void Baglan()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2PT82S1\;Initial Catalog=Galeri;Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
        }
    }
}
