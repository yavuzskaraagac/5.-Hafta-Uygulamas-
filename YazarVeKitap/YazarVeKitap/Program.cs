using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazarVeKitap
{
    class Yazar
    {
        public string Ad { get; set; }
        public string Ulke { get; set; }
        public List<Kitap> Kitaplar { get; set; }

        public Yazar(string ad, string ulke)
        {
            Ad = ad;
            Ulke = ulke;
            Kitaplar = new List<Kitap>();
        }

        public void KitapEkle(Kitap kitap)
        {
            Kitaplar.Add(kitap);
        }
    }

    class Kitap
    {
        public string Baslik { get; set; }
        public string ISBN { get; set; }

        public Kitap(string baslik, string isbn)
        {
            Baslik = baslik;
            ISBN = isbn;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Bir yazar oluştur
            Yazar yazar = new Yazar("Fyodor Dostoyevski", "Rusya");

            // Kitaplar oluştur
            Kitap kitap1 = new Kitap("Suç ve Ceza", "9788408018834");
            Kitap kitap2 = new Kitap("Karamazov Kardeşler", "9780394604152");

            // Yazara kitapları ekle
            yazar.KitapEkle(kitap1);
            yazar.KitapEkle(kitap2);

            // Yazar ve kitap bilgilerini yazdır
            Console.WriteLine($"Yazar: {yazar.Ad}, Ülke: {yazar.Ulke}");
            Console.WriteLine("Kitapları:");
            foreach (var kitap in yazar.Kitaplar)
            {

                Console.WriteLine($"- {kitap.Baslik} (ISBN: {kitap.ISBN})");
               
            }
            Console.ReadLine();
        }


    }
}
