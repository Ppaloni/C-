//Chapter 5, exercise 3 (open exercise 1 and 2)
//Nämä avoimet tehtävä 1 ja 2 olivat täysin samat kuin kappaleen  programming exercises.

//Open exercise 1
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

//Open exercise 2

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