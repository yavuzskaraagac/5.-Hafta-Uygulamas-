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
        public List<Kitap> Kitaplar { get; set; } = new List<Kitap>();

        public void KitapEkle(Kitap kitap)
        {
            Kitaplar.Add(kitap);
            kitap.Yazar = this;
        }
    }

    class Kitap
    {
        public string Baslik { get; set; }
        public DateTime YayinTarihi { get; set; }
        public Yazar Yazar { get; set; }

        public void YazarAtama(Yazar yazar)
        {
            Yazar = yazar;
            yazar.KitapEkle(this);
        }
    }
}
