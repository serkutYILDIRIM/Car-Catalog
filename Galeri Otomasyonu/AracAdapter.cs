using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri_Otomasyonu
{
    class AracAdapter :AracInterface
    {
        private Arac _adapter;


        public AracAdapter(Arac adapter)
        {
            _adapter = adapter;
        }
        public void aracAdapter(Arac ad)
        {
            this._adapter = ad;
        }

        public int AdaracId
        {
            get{return _adapter.AracId;}
            set {_adapter.AracId = value;}
        }


        public string AdMarka
        {
            get{return _adapter.Marka;}
            set{_adapter.Marka = value; ;}
        }

        public string AdModel
        {
            get { return _adapter.Model; }
            set { _adapter.Model = value; ; }
        }

        public string AdPlaka
        {
            get { return _adapter.Plaka; }
            set { _adapter.Plaka = value; ; }
        }

        public string AdRenk
        {
            get { return _adapter.Renk; }
            set { _adapter.Renk = value; ; }
        }

        public string AdYakıt
        {
            get { return _adapter.Yakıt; }
            set { _adapter.Yakıt= value; ; }
        }

        public string AdYıl
        {
            get { return _adapter.Yıl; }
            set { _adapter.Yıl = value; ; }
        }
    }
}
