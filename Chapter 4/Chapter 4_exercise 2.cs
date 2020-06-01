//Chapter 4, exercise 2

/* Kirjoita C#-kielellä ohjelma, joka pyytää ja lukee viisi kokonaislukua näppäimistöltä, 
kirjoittaa ne sopivaan taulukkoon ja lopussa laskee niiden keskiarvon 
ja tulostaa sen näytölle. Käytä keskiarvon laskennassa foreach-lausetta
*/


//Seuraavassa ratkaisu tehtävään

 using System;

class Tehtava4_2
{
    
    static void Main(string[] args)
    {
   
        int[] kokonaisLuvut;
kokonaisLuvut = new int[5];
Console.WriteLine("Anna viisi kokonaislukua:");
kokonaisLuvut[0] = Int32.Parse(Console.ReadLine());
kokonaisLuvut[1] = Int32.Parse(Console.ReadLine());
kokonaisLuvut[2] = Int32.Parse(Console.ReadLine());
kokonaisLuvut[3] = Int32.Parse(Console.ReadLine());
kokonaisLuvut[4] = Int32.Parse(Console.ReadLine());
int summa = 0;

foreach (int x in kokonaisLuvut) {
    summa += x;
}
    int keskiarvo = summa / kokonaisLuvut.Length;  
    Console.WriteLine("keskiarvo: {0}", keskiarvo);

}
        }

//Viopen esimerkkivastaus, joka käytännössä täysin sama

using System;

class Ohjelma
{
    static void Main(string[] args)
    {
        int[] luvut = new int[5];
        Console.WriteLine("Anna viisi kokonaislukua:");
        luvut[0] = Convert.ToInt32(Console.ReadLine());
        luvut[1] = Convert.ToInt32(Console.ReadLine());
        luvut[2] = Convert.ToInt32(Console.ReadLine());
        luvut[3] = Convert.ToInt32(Console.ReadLine());
        luvut[4] = Convert.ToInt32(Console.ReadLine());

        int yhteensa = 0;
        foreach (var luku in luvut)
        {
            yhteensa += luku;
        }

        double keskiarvo = (yhteensa / luvut.Length);

        Console.WriteLine("keskiarvo: " + keskiarvo);
    }
}
