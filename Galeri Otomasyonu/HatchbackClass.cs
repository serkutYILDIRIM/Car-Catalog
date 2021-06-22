using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri_Otomasyonu
{
    class HatchbackClass : AracInterface
    {
        private int aracId;
        private string plaka;
        private string marka;
        private string model;
        private string yıl;
        private string renk;
        private string yakıt;

        public int AdaracId
        {
            get { return aracId; }
            set { aracId = value; }
        }
        public string AdPlaka
        {
            get { return plaka; }
            set { plaka = value; }
        }

        public string AdMarka
        {
            get { return marka; }
            set { marka = value; }
        }

        public string AdModel
        {
            get { return model; }
            set { model = value; }
        }

        public string AdYıl
        {
            get { return yıl; }
            set { yıl = value; }
        }

        public string AdRenk
        {
            get { return renk; }
            set { renk = value; }
        }

        public string AdYakıt
        {
            get { return yakıt; }
            set { yakıt = value; }
        }
    }
}
