//Chapter 4, exercise 5

/* Kirjoita C#-kielellä ohjelma, joka pyytää ja lukee reaalilukuja näppäimistöltä, 
laskee ne yhteen ja näyttää niiden reaaliaikaisen summan samalla, 
kun se pyytää seuraavaa lukua. Ohjelman pitää jatkaa näin niin kauan kuin
lukujen yhteissumma on korkeintaan 100. Jos lukujen yhteissumma ylittää 100, 
ohjelman tulee ilmoittaa, että raja on saavutettu ja se lopettaa toiminnan */

//Tässä ensiversio enne taukoja

using System;
public class Tehtava4_5 {
static void Main(string[] args)
        {
            int sum = 0;
            string nykyNumero = "5";  
            while (nykyNumero != "00")
            {
                int num = Int32.Parse(nykyNumero);
                sum += num;
                Console.WriteLine("Anna luku:\n " + sum);
                nykyNumero = Console.ReadLine();
            }
            Console.Read();
        }
}

//tässä valmis ratkaisu tehtävään kun aloitin alusta uudella ajatuksella.

using System;
public class Tehtava4_5 {
static void Main(string[] args)
        {
            int sum = 0;
            string nykyNumero = "5";  
            while (nykyNumero != "00")
            {
                int num = Int32.Parse(nykyNumero);
                sum += num;
                Console.WriteLine("Anna luku:\n " + sum);
                nykyNumero = Console.ReadLine();
            }
            Console.Read();
        }
}

//tässä Viopen esimerkkivastaus:

class Ohjelma
{
    static void Main(string[] args)
    {
        int summa = 0;

        alku:
        Console.WriteLine("Anna luku:");
        summa += Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(summa);

        if (summa >= 100)
        {
            Console.WriteLine("Raja saavutettu.");
        }
        else
        {
            goto alku;
        }
    }
}