using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Galeri_Otomasyonu
{
    class KullaniciIslemler
    {
        private static KullaniciIslemler nesneKullaniciIslemler = new KullaniciIslemler();

        private KullaniciIslemler()
        {
            Baglan();
        }

        public static KullaniciIslemler NesneKullaniciIslemler()
        {
            return nesneKullaniciIslemler;
        }
        SqlConnection con;
        SqlCommand cmd;
        public void Baglan()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2PT82S1\;Initial Catalog=Galeri;Integrated Security=SSPI;");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public List<KullaniciClass> Listele()
        {

            try
            {
                List<KullaniciClass> kullaniciListesi = new List<KullaniciClass>();
                cmd.CommandText = "Select *From kullanici";
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    KullaniciClass kl = new KullaniciClass();
                    kl.Id = Convert.ToInt32(reader[0].ToString());
                    kl.Ad = reader[1].ToString();
                    kl.Soyad = reader[2].ToString();
                    kl.KullaniciAdi = reader[3].ToString();
                    kl.Sifre = reader[4].ToString();
                    kullaniciListesi.Add(kl);
                }

                return kullaniciListesi;
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
        public void Ekle(KullaniciClass k)
        {
            try
            {
                cmd.CommandText = "Insert Into kullanici (ID,Ad,Soyad,kullaniciAdi,sifre) Values (" + k.Id + ",'" + k.Ad + "','" + k.Soyad + "','" + k.KullaniciAdi + "','" + k.Sifre + "')";

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
        public void Guncelle(KullaniciClass eskiKullanici, KullaniciClass yeniKullanici)
        {
            try
            {
                cmd.CommandText = "Update kullanici SET ad='" + yeniKullanici.Ad + "',soyad='" + yeniKullanici.Soyad + "',kullaniciAdi='" + yeniKullanici.KullaniciAdi +  "',sifre='" + yeniKullanici.Sifre + "' Where ID=" + eskiKullanici.Id + "";
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
        public void Sil(KullaniciClass k)
        {
            try
            {
                cmd.CommandText = "Delete From kullanici Where ID=" + k.Id + "";
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
