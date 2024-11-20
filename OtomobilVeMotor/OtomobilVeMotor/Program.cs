using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomobilVeMotor
{
    public class Otomobil
    {
        public string Marka { get; set; }
        public Motor Motor { get; set; }

        public Otomobil(string marka)
        {
            Marka = marka;
        }

        public void MotorOlustur()
        {
            Motor = new Motor();
        }
    }

    public class Motor
    {
        public int Guc { get; set; }
        public string Tip { get; set; }

        public Motor()
        {
        }

        public void MotorBilgisi()
        {
            // Motor bilgisi alma işlemi.
        }
    }
}
