//Chapter 5, open exercise 4

 //Tämä vielä kesken, palkkojen vertailu saatu tähän mennessä aikaiseksi

using System;

using System;

class Tyontekija
{
    string Nimi;
    string Tehtava;
    int Id;
    float Palkka;



    public Tyontekija(string Nimi, string Tehtava, int Id, float Palkka)
    {
        this.Nimi = Nimi;
        this.Tehtava = Tehtava;
        this.Id = Id;
        this.Palkka = Palkka;
    }

    public override string ToString()
    {
        return Nimi + ", " + Tehtava + ", " + Id + ", " + Palkka;
        
    }
            public void VertailePalkka(Tyontekija tyontekijat)
{ 
    if(this.Palkka > tyontekijat.Palkka);
       System.Console.WriteLine(this.Palkka + " on halvempi kuin " + tyontekijat.Palkka);
       }
}

class TulostaTiedot
{
    static void Main(string[] args)
    {
       Tyontekija[] tyontekija = new Tyontekija[3];
       tyontekija[0] = new Tyontekija("Arttu Wiskari", "Laulaja", 3, 20.40f);
       tyontekija[1] = new Tyontekija("Sami", "Samittaja", 2, 64.43f);
       tyontekija[2] = new Tyontekija("Tuzi", "Tuzittaja", 1, 62.53f);
       tyontekija[0].VertailePalkka(tyontekija[1]);
    }
}