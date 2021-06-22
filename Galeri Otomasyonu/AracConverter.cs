using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri_Otomasyonu
{
    class AracConverter
    {
        public static AracInterface CreateConverterClass(string secim)
        {
            AracInterface selectedStrategy = null;
            if (secim == "jeep")
            {
                selectedStrategy = new JeepClass();
            }
            else if (secim == "hatchback")
            {
                selectedStrategy = new HatchbackClass();
            }
            return selectedStrategy;
        }
 
    }
}
