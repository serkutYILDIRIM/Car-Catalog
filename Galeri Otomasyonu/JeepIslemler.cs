using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Galeri_Otomasyonu
{
    class JeepIslemler
    {
        private static JeepIslemler nesneJeepIslemler = new JeepIslemler();

        private JeepIslemler()
        {
            Baglan();
        }

        public static JeepIslemler NesneJeepIslemler()
        {
            return nesneJeepIslemler;
        }
        SqlConnection con;
        SqlCommand cmd;
        public void Baglan()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2PT82S1\;Initial Catalog=Galeri;Integrated Security=SSPI;");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public List<JeepClass> Listele()
        {

            try
            {
                List<JeepClass> aracListesi = new List<JeepClass>();
                cmd.CommandText = "Select *From Jeep";
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    AracInterface jp = AracConverter.CreateConverterClass("jeep");
                    jp.AdaracId = Convert.ToInt32(reader[0].ToString());
                    jp.AdMarka = reader[1].ToString();
                    jp.AdModel = reader[2].ToString();
                    jp.AdYıl = reader[3].ToString();
                    jp.AdRenk = reader[4].ToString();
                    jp.AdYakıt = reader[5].ToString();
                    jp.AdPlaka = reader[6].ToString();
                    aracListesi.Add((JeepClass)jp);
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
        public void Ekle(JeepClass j)
        {
            try
            {
                cmd.CommandText = "Insert Into jeep (aracıd,marka,model,yıl,renk,yakıt,plaka) Values (" + j.AdaracId + ",'" + j.AdMarka + "','" + j.AdModel + "','" + j.AdYıl + "','" + j.AdRenk + "','" + j.AdYakıt + "','"  + j.AdPlaka + "')";

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
        public void Guncelle(JeepClass eskiJeep, JeepClass yeniJeep)
        {
            try
            {
                cmd.CommandText = "Update jeep SET plaka='" + yeniJeep.AdPlaka + "',marka='" + yeniJeep.AdMarka + "',model='" + yeniJeep.AdModel + "',yıl='" + yeniJeep.AdYıl + "',renk='" + yeniJeep.AdRenk + "',yakıt='" + yeniJeep.AdYakıt + "' Where aracıd=" + eskiJeep.AdaracId + "";
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
        public void Sil(JeepClass j)
        {
            try
            {
                cmd.CommandText = "Delete From jeep Where aracıd=" + j.AdaracId + "";
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
