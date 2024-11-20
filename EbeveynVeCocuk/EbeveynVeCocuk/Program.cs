using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbeveynVeCocuk
{
    class Ebeveyn
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public List<Cocuk> Cocuklar { get; set; } = new List<Cocuk>();

        public void CocukEkle(Cocuk cocuk)
        {
            Cocuklar.Add(cocuk);
            cocuk.Ebeveyn = this;
        }
    }

    class Cocuk
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public Ebeveyn Ebeveyn { get; set; }

        public void EbeveynAtama(Ebeveyn ebeveyn)
        {
            Ebeveyn = ebeveyn;
            ebeveyn.CocukEkle(this);
        }
    }
}
