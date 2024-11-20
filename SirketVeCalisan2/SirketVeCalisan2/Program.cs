using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketVeCalisan2
{
    class Sirket
    {
        public string Ad { get; set; }
        public List<Calisan> Calisanlar { get; set; } = new List<Calisan>();

        public Sirket(string ad)
        {
            Ad = ad;
        }

        public void CalisanEkle(Calisan calisan)
        {
            if (!Calisanlar.Contains(calisan))
            {
                Calisanlar.Add(calisan);
            }
        }

        public void SirketBilgisi()
        {
            Console.WriteLine($"Şirket Adı: {Ad}");
            Console.WriteLine("Çalışanlar:");
            foreach (var calisan in Calisanlar)
            {
                calisan.CalisanBilgisi();
            }
        }
    }

    class Calisan
    {
        public string Ad { get; set; }
        public string Pozisyon { get; set; }

        public Calisan(string ad, string pozisyon)
        {
            Ad = ad;
            Pozisyon = pozisyon;
        }

        public void CalisanBilgisi()
        {
            Console.WriteLine($"Ad: {Ad}, Pozisyon: {Pozisyon}");
        }
    }
}
