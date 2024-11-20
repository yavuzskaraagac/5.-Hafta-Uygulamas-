using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketVeCalisan
{
    class Sirket
    {
        public string Ad { get; set; }
        public string Konum { get; set; }
        public List<Calisan> Calisanlar { get; set; } = new List<Calisan>();

        public void CalisanEkle(Calisan calisan)
        {
            Calisanlar.Add(calisan);
            calisan.Sirket = this;
        }
    }

    class Calisan
    {
        public string Ad { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public Sirket Sirket { get; set; }

        public void SirketAtama(Sirket sirket)
        {
            Sirket = sirket;
            sirket.CalisanEkle(this);
        }
    }
}
