using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kordamine_OOP_1;

//Koduloom kass = new Koduloom("Murka","Valge",'E',5.5,7,true);
//kass.print_info();
//Koduloom kassKloon = new Koduloom(kass);
//kassKloon.muuda_Nimi("bunda");
//kassKloon.muuda_Varv("Punane");
//kassKloon.muuda_Elav(false);
//kassKloon.muuda_Kaal(4.4);
//kassKloon.muuda_Vanus(3);
//kassKloon.print_info();

//Koer koer = new Koer("GShepard","Bobik", "Must", Koduloom.sugu.isane,12.5,4,true);
//koer.print_info();



//HARJUTUS
//ISIK

//Isik human = new Isik("Anton",2005,Isik.sugu.mees);
//human.PRINTinfo();
//int a=human.ArvutaVanus();
//Console.WriteLine(a);
//human.muudaNimi("Antoha");
//human.PRINTinfo();

//TOOTAJA 
Tootaja Gosha = new Tootaja("Gosha", 1990, Isik.sugu.mees, "Kodus", "Domohozaika", 100000);
Tootaja Antosha = new Tootaja("Antosha", 2004, Isik.sugu.mees, "ArturINC", "MoiSekretar", 250000);
Tootaja Grisha = new Tootaja("Grisha", 2002, Isik.sugu.naine, "Zavod", "Rabochii", 15);
Tootaja Sasha = new Tootaja("Sasha", 1998, Isik.sugu.mees, "Konditerskaja", "Konditer", 100);

//OPILANE
Opilane Dasha = new Opilane("Dasha", 2002, Isik.sugu.naine, "Narva", 1, "THK", Opilane.Kursus.First, Opilane.Spetsialiseerumine.IT, 5.0);
int a = Dasha.Toetus();
Console.WriteLine(a);
Opilane Artem = new Opilane("Artem",2005,Isik.sugu.mees,"Tallinn",3,"THK",Opilane.Kursus.Second,Opilane.Spetsialiseerumine.Ehitaja,4.0);
int b = Artem.Toetus();
Console.WriteLine(b);

List<Tootaja> Humans = new List<Tootaja>();
Humans.Add(Antosha);
Humans.Add(Grisha);
Humans.Add(Gosha);


foreach (Isik s in Humans)
{
    Console.WriteLine(s.nimi);
}
//zapisivaet v txt fail
StreamWriter sw = new StreamWriter(@"..\..\..\Inimesed.txt", false);
foreach (Tootaja x in Humans)
{
    x.PRINTinfo();
    sw.WriteLine(x.nimi+","+x.synniAasta+"," + x.Sugu + ","+x.asutus+","+x.amet+","+x.tootasu);
}
sw.Close();
StreamReader fromFile = new StreamReader(@"..\..\..\Inimesed.txt");
string text = fromFile.ReadToEnd();
Console.WriteLine(text);
fromFile.Close();
//zapisivaet v txt file


//sosdaet is txt file tootajov
List<Tootaja> tootajad = new List<Tootaja>();
StreamReader sr = new StreamReader(@"..\..\..\Inimesed.txt");
string text2;
while ((text2 = sr.ReadLine()) != null)
{
    string[] rida = text2.Split(",");
    tootajad.Add(new Tootaja(rida[0], Converter(rida[1]), TextFailToEnum(rida[2]), rida[3], rida[4], Converter(rida[5])));
}
sr.Close();

foreach (var x in tootajad)
{
    Console.WriteLine(x.nimi+" "+x.synniAasta+" "+x.Sugu+" "+x.asutus+" "+x.amet+" "+x.tootasu);
}
Console.ReadLine();
//sosdaet is txt file tootajov



//methods
int Converter(string variable)
{
    string num = variable;
    int Num = Int32.Parse(variable);
    return Num;
}

Isik.sugu TextFailToEnum(string variable)
{
    switch (variable)
    {
        case "naine":
            return Isik.sugu.naine;
        default:
            return Isik.sugu.mees;
    }
}