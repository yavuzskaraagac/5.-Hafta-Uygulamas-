using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulVeOgrenci
{
    public class Okul
    {
        public string Ad { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }

        public Okul(string ad)
        {
            Ad = ad;
            Ogrenciler = new List<Ogrenci>();
        }

        public void OgrenciOlustur()
        {
            // Yeni bir öğrenci oluşturma işlemi.
        }
    }

    public class Ogrenci
    {
        public string Ad { get; set; }
        public int Yas { get; set; }

        public Ogrenci(string ad, int yas)
        {
            Ad = ad;
            Yas = yas;
        }

        public void OgrenciBilgisi()
        {
            // Öğrenci bilgisi alma işlemi.
        }
    }
}
