using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaglıkOcagıOtomasyonu
{
    public class Person
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string DogumYeri { get; set; }
        public string BabaAdi { get; set; }
        public string AnneAdi { get; set; }
        public string Cinsiyet{ get; set; }
        public string KanGrubu { get; set; }
        public string MedeniHali { get; set; }
        public string Adres { get; set; }
        public decimal CepTel { get; set; }
    }
}
