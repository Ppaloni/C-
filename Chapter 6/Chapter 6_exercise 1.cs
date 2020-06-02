//Chapter 6, exercise 1

/* Kirjoita C#-kielellä ohjelma, jossa määrittelet Kirja-luokan. Kirja-luokan kentät ovat 
nimi, kirjailija, kustantaja, hinta sekä teemanNimi. 
Määrittele luokalle sopivat muodostimet sekä HaeKirja()- ja VaihdaTeema()-metodit. 
HaeKirja()-metodi saa parametrina nimen ja 
vertaile sitä kirjan nimeen. Metodin tulee tulostaa 
kirjan loput tiedot jos parametrin ja kirjan nimi ovat 
samat ja muussa tapauksessa ilmoittaa, että kirjaa ei löytynyt. 
VaihdaTeema() on staattinen metodi, jolla muutat teeman nimeä. 
Luo Main()-metodissa muutama olio luokasta ja kutsu HaeKirja()- ja VaihdaTeema()-metodit.

 

Ohje: osa ohjelmakoodista on annettu, täydennä ohjelma vain puuttuvilta osin.  */

//Tässä ratkaisu tehtävään

using System;
using static Kirja;

class Kirja
{
    /* Määritellään luokan kentät. Kentät ovat oletusarvoiesti private */
    public string Nimi;
    string kirjailija;
    string kustantaja;
    float hinta;
    string teema;
/* staattinen muuttuja teemanNimi. Tätä voidaan käsitellä staattisella metodilla !  */
    static string teemaNimi;

    public Kirja(string Nimi, string kirjailija, string kustantaja, float hinta, string teema)
    {
        /* Määritellään luokalle oletusmuodostin ja kentät alustetaan oletusarvoilla. */
        this.Nimi = Nimi;
        this.kirjailija = kirjailija;
        this.kustantaja = kustantaja;
        this.hinta = hinta;
        this.teema = teema;
    }
    public void Tulosta()
    {
        Console.WriteLine("{0}, {1}, {2}, {3}, {4}", Nimi, kirjailija, kustantaja, hinta, teema);
    }

    public void HaeKirja(string Nimi)
    {
        if (this.Nimi.Equals(Nimi))
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", Nimi, kirjailija, kustantaja, teema, hinta);
        }
        else
            Console.WriteLine("Kirjaa ei löytynyt");
    }

    public static void VaihdaTeema(Kirja kirja, string teema)
        {
            kirja.teema = teema;
          
        }

}

    class Program
    {



//Tämä oli Viopen antama MAIN valmiiksi
static void Main(string[] args) { 
    Kirja k = new Kirja("Kirja", "K.Kirjoittaja", "Kustannys Oy", 21.50f, "Dekkari");
    Kirja k2 = new Kirja("Toinen Kirja", "O.Kirjailija", "Kustantaja Ab", 36.90f, "Fantasia");
    k.HaeKirja(k.Nimi);
    VaihdaTeema(k2, "Jännitys"); 
    k2.HeaKirja(k2.Nimi);
}

//Viopen esimerkkivastaus

using System;

class Kirja
{
    string Nimi;
    string Kirjailija;
    string Kustantaja;
    float Hinta;
    string TeemanNimi;

    public Kirja(string nimi, string kirjailija, string kustantaja, float hinta, string teema)
    {
        this.Nimi = nimi;
        this.Kirjailija = kirjailija;
        this.Kustantaja = kustantaja;
        this.Hinta = hinta;
        this.TeemanNimi = teema;
    }

    public void HaeKirja(string nimi)
    {
        if (nimi.Equals(this.Nimi))
        {
            Console.WriteLine(Nimi + ", " + Kirjailija + ", " + Kustantaja + ", " + TeemanNimi + ", " + Hinta);
        }
        else
        {
            Console.WriteLine("Kirjaa ei löydy nimellä " + nimi);
        }
    }

    public static void VaihdaTeema(Kirja k, string teema)
    {
        k.TeemanNimi = teema;
    }

    static void Main(string[] args)
    {
        Kirja k = new Kirja("Kirja", "K. Kirjoittaja", "Kustannus Oy", 21.50f, "Dekkari");
        Kirja k2 = new Kirja("Toinen Kirja", "O. Kirjailija", "Kustantaja Ab", 36.90f, "Fantasia");
        k.HaeKirja(k.Nimi);
        VaihdaTeema(k2, "Jännitys");
        k2.HaeKirja(k2.Nimi);
    }
}