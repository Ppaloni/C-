//Chapter 3, exercise 7

//Tällä laitoin tehtävän läpi, jotta sain mallivastauksen esiin ja apua. Olin siis täysin jumissa tämän kanssa.
using System;

class Tehtava3_7
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Anna binääriluvut 11001101 sekä 01010111:");
        var binaari1 = Convert.ToInt32(Console.ReadLine());
        var binaari2 = Convert.ToInt32(Console.ReadLine());
        int result = 205 ^ 87;
      

        Console.WriteLine("{2}", binaari1, binaari2, result);
    }
}

//Tilanne jossa olin jumissa oli seuraava: 

using System;

class Tehtava3_7
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Anna binääriluvut 11001101 sekä 01010111:");
        var binaari1 = Convert.ToInt32(Console.ReadLine());
        var binaari2 = Convert.ToInt32(Console.ReadLine());
        int result = binaari1 ^ binaari2;
      

        Console.WriteLine("{0} ^ {1} = {2}", binaari1, binaari2, result);
    }
}

//uskoisin, että tässä väärin on tuo var joka pitäisi olla byte ja sitten lähteä tekemään
//convertToSingle kautta tjsp. 

//Kurssin esimerkkivastaus
//Käytännössä oma vastaus siis oli jo aika lähellä, mutta käyttää tuli "long" ja "ConvertToInt64, sekä laittaa tuo
//,2 tuonne (Console.ReadLine) sisälle

using System;

class Ohjelma
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Anna binääriluvut 11001101 sekä 01010111:");
        long luku1 = Convert.ToInt64(Console.ReadLine(), 2);
        long luku2 = Convert.ToInt64(Console.ReadLine(), 2);
        Console.WriteLine(luku1^luku2);
    }
}