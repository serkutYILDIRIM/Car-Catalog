using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri_Otomasyonu
{
    class KullaniciClass
    {
        private int id;
        private string kullaniciAdi;
        private string ad;
        private string soyad;
        private string sifre;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string KullaniciAdi
        {
            get { return kullaniciAdi; }
            set { kullaniciAdi = value; }
        }
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }

    }
}
