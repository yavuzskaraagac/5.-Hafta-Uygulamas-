using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanVeDepartman
{
    class Departman
    {
        public string Ad { get; set; }
        public string Lokasyon { get; set; }

        public Departman(string ad, string lokasyon)
        {
            Ad = ad;
            Lokasyon = lokasyon;
        }
    }

    class Calisan
    {
        public string Ad { get; set; }
        public string Pozisyon { get; set; }
        public Departman Departman { get; private set; } 

        public Calisan(string ad, string pozisyon)
        {
            Ad = ad;
            Pozisyon = pozisyon;
        }

        public void DepartmanAtama(Departman departman)
        {
            Departman = departman;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Bir departman oluştur
            Departman departman = new Departman("Yapay Zeka Ve Veri Bilimi", "Elazığ");

            // Çalışan oluştur
            Calisan calisan = new Calisan("Yavuz Selim Karaağaç", "Yazılım Mühendisi");

            // Çalışanı departmana ata
            calisan.DepartmanAtama(departman);

            // Çalışan ve departman bilgilerini yazdır
            Console.WriteLine($"Çalışan: {calisan.Ad}, Pozisyon: {calisan.Pozisyon}");
            Console.WriteLine($"Departman: {calisan.Departman.Ad}, Lokasyon: {calisan.Departman.Lokasyon}");

            // Programı bekletmek için
            Console.ReadLine();
        }
    }
}
