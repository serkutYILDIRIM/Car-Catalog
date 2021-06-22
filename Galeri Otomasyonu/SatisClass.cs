using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri_Otomasyonu
{
    class SatisClass
    {
        private int satisId;
        private string marka;
        private string model;
        private string tur;
        private string plaka;
        private string sTarih;
        private string sFiyat;
        public int SatisId
        {
            get { return satisId; }
            set { satisId = value; }
        }
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        public string Model 
        {
            get { return model; }
            set { model = value; }
        }
        public string Tur
        {
            get { return tur; }
            set { tur = value; }
        }
        public string Plaka
        {
            get { return plaka; }
            set { plaka = value; }
        }
        public string Starih
        {
            get { return sTarih; }
            set { sTarih = value; }
        }
        public string Sfiyat
        {
            get { return sFiyat; }
            set { sFiyat = value; }
        }

    }
}
