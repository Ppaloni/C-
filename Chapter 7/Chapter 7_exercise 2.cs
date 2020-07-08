//Chapter 7, exercise 2

/*Muokkaa edellisen tehtävän ratkaisua siten, että Auto-luokassa ylikirjoitat 
System.Object-luokasta periytyvät ToString()- ja Equals(obj, obj)-metodit.
Ohje: osa ohjelmakoodista on annettu, täydennä ohjelma vain puuttuvilta osin. */


//Ei oikeen lähtenyt tämä ToString override :(

//Pitkän pähkäilyn jälkeen Viopen compiler päästi tämän läpi
using System;

class KulkuValine
{
    protected string tyyppi;
    protected string merkki;
    protected int vuosiMalli;
    protected float hinta;

    public KulkuValine()
    {

    }

    public KulkuValine(string tyyppi, string merkki, int vuosiMalli, float hinta)
    {
        this.tyyppi = tyyppi;
        this.merkki = merkki;
        this.vuosiMalli = vuosiMalli;
        this.hinta = hinta;
    }

    public virtual void TulostaTiedot()
    {
        Console.WriteLine(tyyppi + ", " + merkki + ", " + vuosiMalli + ", " + hinta);
    }

}

class Auto : KulkuValine
{
    protected int koneenKoko;
    protected string malli;
    protected int ovienLkm;

    public Auto(string tyyppi, string merkki, int vuosiMalli, float hinta, int koneenKoko, string malli, int ovienLkm)
    {
        this.tyyppi = tyyppi;
        this.merkki = merkki;
        this.vuosiMalli = vuosiMalli;
        this.hinta = hinta;
        this.koneenKoko = koneenKoko;
        this.malli = malli;
        this.ovienLkm = ovienLkm;
    }
    public override string ToString()
    {
        return string.Format(tyyppi + ", " + merkki + ", " + vuosiMalli + ", " + hinta+", "+koneenKoko+", "+malli+", "+ovienLkm);
    }
}


class Ohjelma
{
    static void Main(string[] args)
    {
        Auto a = new Auto("maasto", "Honda", 2014, 18190f, 143, "Civic", 4);
        Auto a2 = new Auto("farmari", "Skoda", 2014, 18190f, 151, "Octavia" ,4);
        Console.WriteLine(a.ToString() + "\n" + a2.ToString());
        Console.WriteLine(a.Equals(a2));
    }
}

//Viopen mallivastaus tehtävään:

using System;

class KulkuValine
{
    protected string tyyppi;
    protected string merkki;
    protected int vuosiMalli;
    protected float hinta;

    public KulkuValine()
    {

    }

    public KulkuValine(string tyyppi, string merkki, int vuosiMalli, float hinta)
    {
        this.tyyppi = tyyppi;
        this.merkki = merkki;
        this.vuosiMalli = vuosiMalli;
        this.hinta = hinta;
    }

    public virtual void TulostaTiedot()
    {
        Console.WriteLine(tyyppi + ", " + merkki + ", " + vuosiMalli + ", " + hinta);
    }

}

class Auto : KulkuValine
{
    protected int koneenKoko;
    protected string malli;
    protected int ovienLkm;

    public Auto(string tyyppi, string merkki, int vuosiMalli, float hinta, int koneenKoko, string malli, int ovienLkm)
    {
        this.tyyppi = tyyppi;
        this.merkki = merkki;
        this.vuosiMalli = vuosiMalli;
        this.hinta = hinta;
        this.koneenKoko = koneenKoko;
        this.malli = malli;
        this.ovienLkm = ovienLkm;
    }

    public override void TulostaTiedot()
    {
        Console.WriteLine(tyyppi + ", " + merkki + ", " + vuosiMalli + ", " + hinta+", "+koneenKoko+", "+malli+", "+ovienLkm);
    }

    public override string ToString()
    {
        return tyyppi + ", " + merkki + ", " + vuosiMalli + ", " + hinta + ", " + koneenKoko + ", " + malli + ", " + ovienLkm;
    }

    public override bool Equals(object o)
    {
        return base.Equals(o);
    }
	public override int GetHashCode()
    {
        return this.GetHashCode();
    }
}

class Ohjelma
{
    static void Main(string[] args)
    {
        Auto a = new Auto("maasto", "Honda", 2014, 18190f, 143, "Civic", 4);
        Auto a2 = new Auto("farmari", "Skoda", 2014, 22990f, 151, "Octavia", 4);
        Console.WriteLine(a.ToString() + "\n" + a2.ToString());
        Console.WriteLine(a.Equals(a2));
    }
}