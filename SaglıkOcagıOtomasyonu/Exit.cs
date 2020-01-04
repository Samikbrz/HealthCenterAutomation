using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaglıkOcagıOtomasyonu
{
    public class Exit
    {
        public int ID { get; set; }
        public string TC { get; set; }
        public DateTime SevkTarihi { get; set; }
        public DateTime CıkısTarihi { get; set; }
        public string Odeme { get; set; }
        public decimal ToplamTutar { get; set; }
    }
}
