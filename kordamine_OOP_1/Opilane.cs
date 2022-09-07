using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine_OOP_1
{
    public class Opilane : Isik
    {
        public string kooliNimi;
        public enum Kursus { First,Second,Third }
        Kursus kursus;
        public enum Spetsialiseerumine { Ehitaja,Developer,IT }
        Spetsialiseerumine spetsialiseerumine;
        
        public string city;
        public int fMembers;


        public double averageGrade;

        public Opilane() { }
        public Opilane(string nimi, int synniAasta, sugu Sugu, string city,int fMembers, string kooliNimi, Kursus kursus, Spetsialiseerumine spetsialiseerumine, double averageGrade) : base(nimi, synniAasta, Sugu)
        {
            this.averageGrade= averageGrade;
            this.fMembers = fMembers;
            this.city = city;
            this.kooliNimi = kooliNimi;
            this.kursus = kursus;
            this.spetsialiseerumine = spetsialiseerumine;
        }

        
        public int Toetus()
        {
            int soidutoetus=0;
            int pohitoetus=0;
            int eritoetus = 0;
            if (city=="Tallinn")
            {
                soidutoetus = 0;
            }
            else
            {
                soidutoetus = 20;
            }
            if (averageGrade>3.5)
            {
                pohitoetus = 60;
            }
            else
            {
                pohitoetus=0;
            }
            for (int i = 0; i < fMembers; i++)
            {
                eritoetus += 5;
            }

            int koostoetus = soidutoetus + pohitoetus + eritoetus;

            return koostoetus;
        }

        public override void PRINTinfo()
        {
            Console.WriteLine("My name is{0}. I was born in{1}. I am {2}. I live in{3}.{4} I have {5} family members. I am studying in {6}. I am studying to become {7}.",nimi,synniAasta,Sugu,city,fMembers,kooliNimi, kursus, spetsialiseerumine);
        }

    }
}
