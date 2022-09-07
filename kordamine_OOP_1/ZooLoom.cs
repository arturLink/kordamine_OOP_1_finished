using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine_OOP_1
{
    class Koer : Koduloom
    {
        public string toug; //poroda

        public Koer(string toug, string nimi, string varv, sugu loomaSugu, double kaal, int vanus, bool elav) :base(nimi,varv,loomaSugu,kaal,vanus,elav)
        {
            this.toug = toug;
        }

        public override void print_info()
        {
            if (elav == true)
            {
                elav_text = "elav";
            }
            else
            {
                elav_text = "surnud";
            }

            //if (sugu == 'E')
            //{
            //    sugu_text = "Emane";
            //}
            //else
            //{
            //    sugu_text = "Isane";
            //}

            Console.WriteLine("{0} {1} {2} ta on {3} ja tema kaal on {4} ja ta on {5} aastat vana", toug, nimi, varv, sugu_text, kaal, vanus);
        }
    }
}
