using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Galeri_Otomasyonu
{
    class HatchbackIslemler
    {
        private static HatchbackIslemler nesneHatchbackIslemler = new HatchbackIslemler();

        private HatchbackIslemler()
        {
            Baglan();
        }

        public static HatchbackIslemler NesneHatchbackIslemler()
        {
            return nesneHatchbackIslemler;
        }
        SqlConnection con;
        SqlCommand cmd;
        public void Baglan()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2PT82S1\;Initial Catalog=Galeri;Integrated Security=SSPI;");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public List<HatchbackClass> Listele()
        {

            try
            {
                List<HatchbackClass> aracListesi = new List<HatchbackClass>();
                cmd.CommandText = "Select *From hatchback";
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    AracInterface hb = AracConverter.CreateConverterClass("hatchback");
                    hb.AdaracId = Convert.ToInt32(reader[0].ToString());
                    hb.AdMarka = reader[1].ToString();
                    hb.AdModel = reader[2].ToString();
                    hb.AdYıl = reader[3].ToString();
                    hb.AdRenk = reader[4].ToString();
                    hb.AdYakıt = reader[5].ToString();
                    hb.AdPlaka = reader[6].ToString();
                    aracListesi.Add((HatchbackClass)hb);
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
        public void Ekle(HatchbackClass h)
        {
            try
            {
                cmd.CommandText = "Insert Into hatchback (aracıd,marka,model,yıl,renk,yakıt,plaka) Values (" + h.AdaracId + ",'" + h.AdMarka + "','" + h.AdModel + "','" + h.AdYıl + "','" + h.AdRenk + "','" + h.AdYakıt + "','" + h.AdPlaka + "')";

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
        public void Guncelle(HatchbackClass eskiHatchback, HatchbackClass yeniHatchback)
        {
            try
            {
                cmd.CommandText = "Update hatchback SET plaka='" + yeniHatchback.AdPlaka + "',marka='" + yeniHatchback.AdMarka + "',model='" + yeniHatchback.AdModel + "',yıl='" + yeniHatchback.AdYıl + "',renk='" + yeniHatchback.AdRenk + "',yakıt='" + yeniHatchback.AdYakıt + "' Where aracıd=" + eskiHatchback.AdaracId + "";
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
        public void Sil(HatchbackClass h)
        {
            try
            {
                cmd.CommandText = "Delete From hatchback Where aracıd=" + h.AdaracId + "";
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
