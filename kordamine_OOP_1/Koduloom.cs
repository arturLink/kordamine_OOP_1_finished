using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine_OOP_1
{
    abstract class Koduloom
    {
        public string nimi;
        public string varv;
        public enum sugu {isane,emane};
        public sugu loomaSugu;
        //public char sugu;
        public double kaal;
        public int vanus;
        public bool elav; // kui true, siis elav, kui false, siis on surnud
        public string elav_text;
        public string sugu_text;

        public Koduloom()
        { }

        public Koduloom(string nimi, string varv, sugu loomaSugu, double kaal = 0.0, int vanus = 0, bool elav = false)
        {
            this.nimi = nimi;
            this.varv = varv;
            this.loomaSugu = loomaSugu;
            this.kaal = kaal;
            this.vanus = vanus;
            this.elav = elav;
        }

        public Koduloom(Koduloom loom) //kloonimiseks
        {
            this.nimi = loom.nimi;
            this.varv = loom.varv;
            //this.sugu = loom.sugu;
            this.kaal = loom.kaal;
            this.vanus = loom.vanus;
            this.elav = loom.elav;
        }

        public abstract void print_info();

        //public void print_info()
        //{
        //    if (elav == true)
        //    {
        //        elav_text = "elav";
        //    }
        //    else
        //    {
        //        elav_text = "surnud";
        //    }

        //    if (sugu == 'E')
        //    {
        //        sugu_text = "Emane";
        //    }
        //    else
        //    {
        //        sugu_text = "Isane";
        //    }

        //    Console.WriteLine("{0} {1} {2} ta on {3} ja tema kaal on {4} ja ta on {5} aastat vana", elav_text, varv, nimi, sugu_text, kaal, vanus);
        //}

        //    public void muuda_Nimi(string uusNimi)
        //    {
        //        nimi = uusNimi;
        //    }
        //    public void muuda_Varv(string uusVarv)
        //    {
        //        varv = uusVarv;
        //    }
        //    public void muuda_Kaal(double uusKaal)
        //    {
        //        kaal = uusKaal;
        //    }
        //    public void muuda_Vanus(int uusVanus)
        //    {
        //        vanus = uusVanus;
        //    }
        //    public void muuda_Elav(bool uusElav)
        //    {
        //        elav = uusElav;
        //    }
        //    public void muuda_Sugu(char uusSugu)
        //    {
        //        sugu = uusSugu;
        //    }
    }
}
