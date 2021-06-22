using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Galeri_Otomasyonu
{
    class SedanIslemler
    {
        private static SedanIslemler nesneSedanIslemler = new SedanIslemler();

        private SedanIslemler()
        {
            Baglan();
        }

        public static SedanIslemler NesneSedanIslemler()
        {
            return nesneSedanIslemler;
        }
        SqlConnection con;
        SqlCommand cmd;
        public void Baglan()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2PT82S1\;Initial Catalog=Galeri;Integrated Security=SSPI;");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public List<SedanClass> Listele()
        {

            try
            {
                List<SedanClass> aracListesi = new List<SedanClass>();
                cmd.CommandText = "Select *From sedan";
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Arac ar = new Arac();
                    SedanClass sd = new AracAdapter(ar);
                    sd.AdaracId = Convert.ToInt32(reader[0].ToString());
                    sd.AdMarka = reader[1].ToString();
                    sd.AdModel = reader[2].ToString();
                    sd.AdYıl = reader[3].ToString();
                    sd.AdRenk = reader[4].ToString();
                    sd.AdYakıt = reader[5].ToString();
                    sd.AdPlaka = reader[6].ToString();
                    aracListesi.Add(sd);
                }

                return aracListesi;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        public void Ekle(SedanClass s)
        {
            try
            {
                cmd.CommandText = "Insert Into sedan (aracıd,marka,model,yıl,renk,yakıt,plaka) Values (" + s.AdaracId + ",'" + s.AdMarka + "','" + s.AdModel + "','" + s.AdYıl + "','" + s.AdRenk + "','" + s.AdYakıt + "','" + s.AdPlaka + "')";

                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

        }
        public void Guncelle(SedanClass eskiSedan, SedanClass yeniSedan)
        {
            try
            {
                cmd.CommandText = "Update sedan SET plaka='" + yeniSedan.AdPlaka + "',marka='" + yeniSedan.AdMarka + "',model='" + yeniSedan.AdModel + "',yıl='" + yeniSedan.AdYıl + "',renk='" + yeniSedan.AdRenk + "',yakıt='" + yeniSedan.AdYakıt + "' Where aracıd=" + eskiSedan.AdaracId + "";
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

        }
        public void Sil(SedanClass s)
        {
            try
            {
                cmd.CommandText = "Delete From sedan Where aracıd=" + s.AdaracId + "";
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

    }
}
