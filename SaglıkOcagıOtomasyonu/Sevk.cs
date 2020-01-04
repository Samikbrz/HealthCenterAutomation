using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaglıkOcagıOtomasyonu
{
    public class Sevk
    {        
        public int ID { get; set; }
        public string TCKimlikNo { get; set; }
        public DateTime SevkTarihi { get; set; }
        public string DosyaNo { get; set; }
        public string Poliklinik { get; set; }
        public DateTime Saat { get; set; }
        public string YapılanIslem { get; set; }
        public string DrKodu { get; set; }
        public int Miktar { get; set; }
        public int BirimFiyat { get; set; }
        public int Sira { get; set; }
        [DisplayName("Taburcu")]
        public string taburcu { get; set; }
        public int ToplamTutar
        {
            get
            {
                return Miktar*BirimFiyat;
            }
            set
            {
                BirimFiyat = value;
            }
        }
    }
}
