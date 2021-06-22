using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Galeri_Otomasyonu
{
    class SatisIslemler
    {
        private static SatisIslemler nesneSatisIslemler = new SatisIslemler();

        private SatisIslemler()
        {
            Baglan();
        }

        public static SatisIslemler NesneSatisIslemler()
        {
            return nesneSatisIslemler;
        }
        SqlConnection con;
        SqlCommand cmd;
        public void Baglan()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2PT82S1\;Initial Catalog=Galeri;Integrated Security=SSPI;");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public List<SatisClass> Listele()
        {

            try
            {
                List<SatisClass> satisListesi = new List<SatisClass>();
                cmd.CommandText = "Select *From satıs";
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SatisClass st = new SatisClass();
                    st.SatisId = Convert.ToInt32(reader[0].ToString());
                    st.Marka = reader[1].ToString();
                    st.Model = reader[2].ToString();
                    st.Tur = reader[3].ToString();
                    st.Plaka = reader[4].ToString();
                    st.Starih = reader[5].ToString();
                    st.Sfiyat = reader[6].ToString();
                    satisListesi.Add(st);
                }

                return satisListesi;
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
        public void Ekle(SatisClass s)
        {
            try
            {
                cmd.CommandText = "Insert Into satıs (satisId,marka,model,tur,plaka,sTarih,sFiyat) Values (" + s.SatisId + ",'" + s.Marka + "','" + s.Model + "','" + s.Tur + "','" + s.Plaka + "','" + s.Starih + "','" + s.Sfiyat + "')";

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
        public void Guncelle(SatisClass eskiSatis, SatisClass yeniSatis)
        {
            try
            {
                cmd.CommandText = "Update satıs SET marka='" + yeniSatis.Marka + "',model='" + yeniSatis.Model + "',tur='" + yeniSatis.Tur + "',plaka='" + yeniSatis.Plaka + "',sTarih='" + yeniSatis.Starih + "',sFiyat='" + yeniSatis.Sfiyat + "' Where satisId=" + eskiSatis.SatisId + "";
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
        public void Sil(SatisClass s)
        {
            try
            {
                cmd.CommandText = "Delete From satıs Where satisId=" + s.SatisId + "";
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
