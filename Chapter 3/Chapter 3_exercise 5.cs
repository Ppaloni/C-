//Chapter 3, exercise 5

// oma vastaukseni tähän tehtävään, jossa kuului käyttää ?-operaattoria(ternary operator).
/*Tehtävänanto oli: Kirjoita C#-kielellä ohjelma, joka pyytää ja lukeekokonaisluvun näppäimistöltä ja käyttämällä ?-operaattoria
(ternary operator) tulostaa "Ei" jos luku on 0 ja "Jaa" muussa tapauksessa. */


//Rivejä omassa vastauksessa on usea, mutta tässä käytetty pohjana edellisen tehtävän vastausta.
using System;

class Tehtava3_5
{
    
    static void Main(string[] args)
    {
    int luku;
        
Console.Write("Anna kokonaisluku:\n");
        
luku = int.Parse(Console.ReadLine());
bool nolla = luku == 0 ? true: false;
bool suurempi= luku > 0 ? true: false;

if (nolla == true) {
Console.WriteLine("Ei");
}
else if (suurempi == true) {
  Console.WriteLine("Jaa");
}
    }
} 

//Kurssin esimerkkivastaus: 

using System;

class Ohjelma
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Anna kokonaisluku:");
        var luku = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(luku == 0 ? "Ei" : "Jaa");
    }
}
