//Chapter 5, exercise 2

/* Kehitä edellisen tehtävän Kirja-luokkaa siten, että määrittelet luokalle toisen metodin, 
jonka parametrina on Kirja-olio. 
Metodin pitää verrata parametrina olevan olion kappalehintaa kutsuvan olion kappalehintaan
ja tulostaa näytölle kumpi kirja on kalliimpi. Sellainen metodi voi näyttää seuraavanlaiselta:


public void VertaileKirja(Kirja kirja)
{
    if(this.kappaleHinta > kirja.kappaleHinta)
    System.Console.WriteLine(this.kirjanNimi + " on kalliimpi  
    kuin " + kirja.kirjanNimi)
    ...
}

 

Ohje: osa ohjelmakoodista on annettu, täydennä ohjelma vain puuttuvilta osin. */

//EXAMPLE  OUTPUT: Kirja on halvempi kuin Toinen Kirja

//Ratkaisu tehtävään
//Puuttumaan jäi else if lausekkeet, jolla oikea vertailu olisi tehty
//mikäli ensimmäinen kirja olisi ollut kalliimpi
//tätä kuitenkaan ei tehtävänannossa mainittu.

using System;

class Kirja
{
    string KirjanNimi;
    string KirjoittajanNimi;
    int Id;
    float KappaleHinta;



    public Kirja(string KirjanNimi, string KirjoittajanNimi, int Id, float KappaleHinta)
    {
        this.KirjanNimi = KirjanNimi;
        this.KirjoittajanNimi = KirjoittajanNimi;
        this.Id = Id;
        this.KappaleHinta = KappaleHinta;
    }

    public override string ToString()
    {
        return KirjanNimi + ", " + KirjoittajanNimi + ", " + Id + ", " + KappaleHinta;
        
    }
            public void VertaileKirja(Kirja kirja)
{ 
    if(this.KappaleHinta > kirja.KappaleHinta);
       System.Console.WriteLine(this.KirjanNimi + " on halvempi kuin " + kirja.KirjanNimi);
       }
    

}
class Ohjelma
{
    static void Main(string[] args)
    {
        Kirja k = new Kirja("Kirja", "K. Kirjoittaja", 528, 21.50f);
        Kirja k2 = new Kirja("Toinen Kirja", "O.Kirjailija", 347, 36.90f);
        k.VertaileKirja(k2);
    }
}

//Viopen esimerkkivastaus tehtävään:

using System;

class Kirja
{
    string KirjanNimi;
    string KirjoittajanNimi;
    int Id;
    float KappaleHinta;

    public Kirja(string KirjanNimi, string KirjoittajanNimi, int Id, float KappaleHinta)
    {
        this.KirjanNimi = KirjanNimi;
        this.KirjoittajanNimi = KirjoittajanNimi;
        this.Id = Id;
        this.KappaleHinta = KappaleHinta;
    }

    public void VertaileKirja(Kirja k)
    {
        if (this.KappaleHinta > k.KappaleHinta)
        {
            Console.WriteLine(this.KirjanNimi + " on kalliimpi kuin " + k.KirjanNimi);
        }
        else if (this.KappaleHinta < k.KappaleHinta)
        {
            Console.WriteLine(this.KirjanNimi + " on halvempi kuin " + k.KirjanNimi);
        }
        else if (this.KappaleHinta == k.KappaleHinta)
        {
            Console.WriteLine("Molemmat kirjat ovat saman hintaisia.");
        }
    }

    public override string ToString()
    {
        return KirjanNimi + ", " + KirjoittajanNimi + ", " + Id + ", " + KappaleHinta;
    }
}

class Ohjelma
{
    static void Main(string[] args)
    {
        Kirja k = new Kirja("Kirja", "K. Kirjoittaja", 528, 21.50f);
        Kirja k2 = new Kirja("Toinen Kirja", "O. Kirjailija", 347, 36.90f);
        k.VertaileKirja(k2);
    }
}