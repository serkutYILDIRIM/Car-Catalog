using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri_Otomasyonu
{
    class Arac 
    {
        private int aracId;
        private string plaka;
        private string marka;
        private string model;
        private string yıl;
        private string renk;
        private string yakıt;

        public int AracId
        {
            get { return aracId; }
            set { aracId = value; }
        }
        public string Plaka
        {
            get { return plaka; }
            set { plaka = value; }
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
        public string Yıl
        {
            get { return yıl; }
            set { yıl = value; }
        }
        public string Renk
        {
            get { return renk; }
            set { renk = value; }
        }
        public string Yakıt
        {
            get { return yakıt; }
            set { yakıt = value; }
        }
    }
}
