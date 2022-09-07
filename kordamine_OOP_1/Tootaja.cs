using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine_OOP_1
{
    public class Tootaja : Isik
    {
        public string asutus;
        public string amet;
        public int tootasu;

        public Tootaja() { }
        public Tootaja(string nimi, int synniAasta, sugu Sugu, string asutus, string amet, int tootasu) : base(nimi,synniAasta,Sugu)
        {
            this.asutus = asutus;
            this.amet = amet;
            this.tootasu = tootasu;
        }
        public double arvutaSissetulek()
        {
            double a = tootasu * 0.33;
            return tootasu - a;
        }

        public override void PRINTinfo()
        {
            Console.WriteLine("ww");
        }
    }
}
