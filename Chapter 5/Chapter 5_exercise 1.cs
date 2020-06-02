//Chapter 5, exercise 1

//Ohjelma, jossa määrittelet Kirja-luokan. 
//Luokan kentät ovat kirjan nimi, kirjoittajan nimi, id-numero sekä kappalehinta. 
//Määrittele luokalle muodostimia sekä metodi, joka tulostaa kirjat tiedot näytölle. 
//Luo pääohjelmassa olioita Kirja-luokasta ja kutsu metodi, joka tulostaa olioiden tiedot näytölle.


//Seuraavassa ratkaisu tehtävään kommenttien kera. 

using System;

//tässä määritellän luokka -> Kirja
class Kirja { 

	//Tässä määritellään attribuutit. Niiden
	//saantimääreet ovat public, mikä tarkoittaa, että ne 
	//ovat näkyvissä myös oman luokkansa (Kirja) ulkopuolella;
	public string kirjanNimi;
	public string kirjoittajanNimi;
	public int Id;
	public double kappaleHinta;
	
	//Seuraavassa määritellään TulostaTiedot()-metodi
	//joka tulostaa asunnon tiedot näytölle.
	public void TulostaTiedot() { 
		Console.Write(kirjanNimi);
		Console.Write(kirjoittajanNimi);
		Console.Write(Id + " ,");
		Console.Write(kappaleHinta);
	}
}

class esimerkki{
	static void Main(string[]args) {
		Kirja kirja;
		
		kirja = new Kirja();
		
		kirja.kirjanNimi = "Kirja, ";
		kirja.kirjoittajanNimi = "K.Kirjoittaja, ";
		kirja.Id = 528;
		kirja.kappaleHinta = 21.5;
		
		kirja.TulostaTiedot();
		
	}
}


//Tässä Viopen esimerkkivastaus

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
}

class Ohjelma
{
    static void Main(string[] args)
    {
        Kirja k = new Kirja("Kirja", "K. Kirjoittaja", 528, 21.50f);
        Console.WriteLine(k.ToString());
    }
}