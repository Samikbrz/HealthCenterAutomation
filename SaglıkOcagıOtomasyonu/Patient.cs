using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaglıkOcagıOtomasyonu
{
    public class Patient:Person
    {
        public string DosyaNo { get; set; }
        public int KurumSicilNo { get; set; }
        public string KurumAdi { get; set; }
        public decimal YakınTel { get; set; }
        public int YakınKurumSicilNo { get; set; }
        public string YakınKurumAdi { get; set; }
    }
}
