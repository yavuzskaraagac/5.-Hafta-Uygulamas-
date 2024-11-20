using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoktorVeHasta
{
    class Doktor
    {
        public string Ad { get; set; }
        public string Brans { get; set; }
        public List<Hasta> Hastalar { get; set; } = new List<Hasta>();

        public void HastaEkle(Hasta hasta)
        {
            Hastalar.Add(hasta);
            hasta.Doktor = this;
        }
    }

    class Hasta
    {
        public string Ad { get; set; }
        public string TCNo { get; set; }
        public Doktor Doktor { get; set; }

        public void DoktorAtama(Doktor doktor)
        {
            Doktor = doktor;
            doktor.HastaEkle(this);
        }
    }
}
