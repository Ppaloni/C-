//Chapter 6, exercise 2

//Tämä ei vielä toimi, jostain syystä viallinen, ei ole selvinnyt miksi. 
//Haetaan apua foorumeilta ja palataan asiaan

//NYT TOIMII TÄMÄ VERSIO! Pieni muutos ja määriteltiin myös tuo k.Hinta eikä vain k.hinta heti tuohon alkuun


/*Kehitä edellisen tehtävän ratkaisua siten, 
että Kirja-luokalle määrittelet Hinta-ominaisuuden. 
Määrättele Hinta-ominaisuudelle set-metodi siten, että sillä 
alustetaan hinta-kenttä ja jos sen saama arvo on yli 30, sitä 
vähennetään 10%:lla. Määrittele get-metodi siten, että se palauttaa 
hinta-kentän arvon. Vihje: set-metodissa voidaan käyttää if-lausetta, 
jossa value on vertailun kohde.*/


using System;
using static Kirja;

class Kirja
{
    public string Nimi;
    string kirjailija;
    string kustantaja;
    public float hinta;
    string teema;


//Tässä tehtävässä muistetaan määritellä myös this.Hinta = hinta; myös tuon toisen hinnan lisäksi
//näin saamme näkyville muuntuneen hinnan ja laskutoimitus set sisällä toimii!
    public Kirja(string Nimi, string kirjailija, string kustantaja, float hinta, string teema)
    {
        this.Nimi = Nimi;
        this.kirjailija = kirjailija;
        this.kustantaja = kustantaja;
        this.hinta = hinta;
        this.Hinta = hinta;
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
        public float Hinta {
      get {return hinta;}
    set { if (hinta > 30) {
         hinta = hinta * 0.9f;
    }
      }
    }

}

    class Program
    { 

      static void Main(string[] args)
    {
      Kirja k = new Kirja("Kirja", "K.Kirjoittaja", "Kustannus Oy", 21.50f, "Dekkari");
      Kirja k2 = new Kirja("Toinen Kirja", "O.Kirjailija", "Kustataja Ab", 33.21f, "Fantasia");
      Console.WriteLine(k.hinta);
      Console.WriteLine(k2.Hinta);
    }
}


//Tässä Viopen esimerkki vastaus
//HUOM! Viope menee aika vauhdilla näissä sillä tehtävänannossa lukee "Käytä edellisen tehtävän ratkaisua", mutta tässä
//esimerkissä ei ole mitään edelliseen tehtävään viittavaa. Kirjaimellisesti ei mitään...


using System;

class Kirja
{

    private float hinta;
    public float Hinta
    {
        get
        {
            return hinta;
        }
        set
        {
            hinta = value > 30 ? (value * 0.90f) : value;
        }  
    }

    public Kirja(string nimi, string kirjailija, string kustantaja, float hinta, string teema)
    {
        this.Hinta = hinta;
    }

    static void Main(string[] args)
    {
        Kirja k = new Kirja("Kirja", "K. Kirjoittaja", "Kustannus Oy", 21.50f, "Dekkari");
        Kirja k2 = new Kirja("Toinen Kirja", "O. Kirjailija", "Kustantaja Ab", 36.90f, "Fantasia");
        Console.WriteLine(k.hinta);
        Console.WriteLine(k2.Hinta);
    }
}