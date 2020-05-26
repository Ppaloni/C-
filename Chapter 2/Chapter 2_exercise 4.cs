//Chapter 2, exercise 4

/*Kirjoita C#-kielellä ohjelma, jossa määrittelet char-tyyppisen muuttujan, jonka alustat heksadesimaaliluvulla. 
Tämän jälkeen, tulosta näytölle muuttujan arvo kokonaislukuna. 
Vihje: Käytä tyyppimuunnosta tulostuksen yhteydessä
*/


//tehtävä läpi stringillä, alempana vaihtoehtoinen ratkaisu char muuttujalla alustettuna. 
using System;
using System.Collections.Generic;
public class Tehtävä2_4 {
 public static void Main() {
      
     string hexval = "5EB3";
   
     int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);

     Console.WriteLine(+decValue);
   }
}


//Tässä tehty tehtävänannon char muuttujan kautta.
//Itselläni jäi omasta  char yrityksestä puuttumaan tuo x kun luotiin char muuttujaa eli oli vain '\5EB3'.
using System;

class Ohjelma
{
    static void Main(string[] args)
    {
        char c = '\x5EB3';
        Console.WriteLine(Convert.ToInt32(c));
    }
}


