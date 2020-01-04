using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaglıkOcagıOtomasyonu
{
    public class Users : Person
    {
        public int KullaniciKodu { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Yetki { get; set; }
        public decimal EvTel { get; set; }
        public string Unvan { get; set; }
        public DateTime IseBaslama { get; set; }
        public decimal Maas { get; set; }
    }
}
