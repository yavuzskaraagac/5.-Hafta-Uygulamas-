using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriVeSiparis
{
    // Müşteri sınıfı
    public class Musteri
    {
        public string Ad { get; set; }         // Müşteri adı
        public string Telefon { get; set; }   // Müşteri telefon numarası

        // Müşteri tarafından sipariş verme metodu
        public Siparis SiparisVer(string durum)
        {
            return new Siparis(DateTime.Now, durum);
        }

        // Yapıcı metot
        public Musteri(string ad, string telefon)
        {
            Ad = ad;
            Telefon = telefon;
        }
    }

    // Sipariş sınıfı
    public class Siparis
    {
        public DateTime Tarih { get; set; }   // Sipariş tarihi
        public string Durum { get; set; }    // Sipariş durumu (örneğin: "Hazırlanıyor")

        // Yapıcı metot
        public Siparis(DateTime tarih, string durum)
        {
            Tarih = tarih;
            Durum = durum;
        }
    }

    // Program sınıfı
    class Program
    {
        static void Main(string[] args)
        {
            // Bir müşteri oluşturuluyor
            Musteri musteri = new Musteri("Yavuz Selim Karaağaç", "05394693207");

            // Müşterinin bir sipariş vermesi
            Siparis siparis1 = musteri.SiparisVer("Hazırlanıyor");
            Siparis siparis2 = musteri.SiparisVer("Tamamlandı");

            // Müşteri bilgileri ve siparişlerin detaylarını yazdırma
            Console.WriteLine($"Müşteri Adı: {musteri.Ad}");
            Console.WriteLine($"Telefon: {musteri.Telefon}");
            Console.WriteLine();
            Console.WriteLine("Siparişler:");
            Console.WriteLine($"1. Sipariş - Tarih: {siparis1.Tarih}, Durum: {siparis1.Durum}");
            Console.WriteLine($"2. Sipariş - Tarih: {siparis2.Tarih}, Durum: {siparis2.Durum}");

            Console.ReadLine();
        }
    }
}

