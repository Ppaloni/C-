//Chapter 3, exercise 4

//Oma vastaus tehtävään, jossa kysyttiin 2 kokonaislukua ja haluttiin tulostus niiden vertailun jälkeen.
using System;

class Tehtava3_2
{
    
    static void Main(string[] args)
    {
        
    int luku1, luku2;
    bool suurempi;
    bool pienempi;
    bool yhtasuuri;
        
Console.Write("Anna kaksi lukua:\n");
        
luku1 = int.Parse(Console.ReadLine());
luku2 = int.Parse(Console.ReadLine());
suurempi = luku1 > luku2;
pienempi = luku1 < luku2;
yhtasuuri = luku1 == luku2;

if (suurempi == true) {
Console.WriteLine(luku1 + " on suurempi kuin " + luku2);
}
	else if (pienempi == true) {
  		Console.WriteLine(luku1 + " on pienempi kuin " + luku2);
}

		else if ( yhtasuuri == true) {
  			Console.WriteLine(luku1 + " on yhtäsuuri kuin " + luku2);
}

    }

//Kurssin esimerkkivastaus
//Tässä ehkä hieman selvemmin luettavissa ja koodirivejä muutama vähemmän, mutta molemmat vastaukset toimivat. 

using System;

class Ohjelma
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Anna kaksi lukua:");
        var luku1 = Convert.ToDouble(Console.ReadLine());
        var luku2 = Convert.ToDouble(Console.ReadLine());
        string vertailu = "";
        if (luku1 < luku2)
        {
            vertailu = "pienempi";
        }
        else if (luku1 > luku2)
        {
            vertailu = "suurempi";
        }
        else if (luku1 == luku2)
        {
            vertailu = "yhtä suuri";
        }
        Console.WriteLine(luku1 +" on {0} kuin "+ luku2, vertailu);
    }
}
