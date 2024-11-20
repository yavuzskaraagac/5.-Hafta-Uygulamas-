using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunVeSiparis
{
    public class Urun
    {
        public string Ad { get; set; }  // Ürün adı (string)
        private int Fiyat { get; set; } // Ürün fiyatı (int)

        // Ürün bilgisi döndüren metot
        public string UrunBilgisi()
        {
            return $"Ürün: {Ad}, Fiyat: {Fiyat} TL";
        }

        // Fiyat için bir getter metot
        public int GetFiyat()
        {
            return Fiyat;
        }

        // Yapıcı metot
        public Urun(string ad, int fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }
    }

    public class Siparis
    {
        public DateTime Tarih { get; set; }  // Sipariş tarihi (DateTime)
        public decimal Toplam { get; set; } // Sipariş toplam tutarı (Decimal)

        // Yapıcı metot
        public Siparis(DateTime tarih, decimal toplam)
        {
            Tarih = tarih;
            Toplam = toplam;
        }
    }

    // Kullanım
    class Program
    {
        static void Main()
        {
            // Örnek bir ürün oluşturma
            Urun urun = new Urun("Telefon", 11000);
            Console.WriteLine(urun.UrunBilgisi());

            // Örnek bir sipariş oluşturma
            Siparis siparis = new Siparis(DateTime.Now, urun.GetFiyat());
            Console.WriteLine($"Sipariş Tarihi: {siparis.Tarih}");
            Console.WriteLine($"Toplam Tutar: {siparis.Toplam} TL");

            Console.ReadLine();
        }
    }
}
