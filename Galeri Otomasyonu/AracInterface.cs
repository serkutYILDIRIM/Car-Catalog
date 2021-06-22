using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri_Otomasyonu
{
    interface AracInterface    {

        int AdaracId { get; set; }
        string AdPlaka { get; set; }

        string AdMarka { get; set; }
        string AdModel { get; set; }

        string AdYıl { get; set; }

        string AdRenk { get; set; }

        string AdYakıt { get; set; }
    }
}
