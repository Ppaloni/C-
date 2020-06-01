//Chapter 4, exercise 3

/* Kirjoita C#-kielellä ohjelma, joka tulostaa näytölle 20 lukua seuraavasta sarjasta. 
Vihje: lukuun ottamatta ensimmäistä lukua, jokainen luku on itseään edeltävien lukujen summa. 
Ensimmäisen luvun perusteella voit laskea kaikki muut luvut.

1, 1, 2, 4, 8, 16,... */


//Tässä ratkaisu tehtävään

using System;

class Tehtava4_3 {
  public static void Main (string[] args) {
      	int x = 1;
    	int z = 2;
    	int c = 0;
    Console.WriteLine(x);
      do {
Console.WriteLine(x);
c += 1;
x *= z;
      }
      while (c!=20);
   }
  }

//Viopen esimerkki vastaus vielä tässä alla

using System;

class Ohjelma
{
    static void Main(string[] args)
    {
        int luku = 1;
		Console.WriteLine(luku);

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(luku);
            luku += luku;
        }
    }