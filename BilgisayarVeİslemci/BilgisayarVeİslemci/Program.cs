using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgisayarVeİslemci
{
    public class Bilgisayar
    {
        public string Model { get; set; }
        public Islemci Islemci { get; set; }

        public Bilgisayar(string model)
        {
            Model = model;
        }

        public void IslemciOlustur()
        {
            Islemci = new Islemci();
        }
    }

    public class Islemci
    {
        public int Cekirdekler { get; set; }
        public int Frekans { get; set; }

        public Islemci()
        {
        }

        public void IslemciBilgisi()
        {
            // Islemci bilgisi alma işlemi.
        }
    }
}
