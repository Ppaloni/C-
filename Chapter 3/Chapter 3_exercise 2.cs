//Chapter 3, exercise 2

//Oma ratkaisu, double tosin ei rajoitu 2 desimaaliin niinkuin tehtävänannossa pyydettiin
//alapuolella ratkaisu tähän
using System;

class Tehtava3_2
{
    
    static void Main(string[] args)
    {
        
    double luku1, luku2;
        
Console.Write("Anna kaksi lukua:\n");
        
luku1 = double.Parse(Console.ReadLine());
luku2 = double.Parse(Console.ReadLine());
        
Console.WriteLine(luku1 + " + "+ luku2 +" = "+ (luku1+luku2));  
Console.WriteLine(luku1 + " - "+ luku2 +" = "+ (luku1-luku2));  
Console.WriteLine(luku1 + " * "+ luku2 +" = "+ (luku1*luku2));  
Console.WriteLine(luku1 + " / "+ luku2 +" = "+ (luku1/luku2));            
    }
}


//tässä esimerkkivastaus, jossa käytetty converttia ja saatu rajattua lopputulos 2 desimaaliin.
using System;

class Ohjelma
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Anna kaksi lukua:");
        var luku1 = Math.Truncate(Convert.ToDecimal(Console.ReadLine()) * 100) / 100;
        var luku2 = Math.Truncate(Convert.ToDecimal(Console.ReadLine()) * 100) / 100;
        var yhteen = luku1 + luku2;
        var vahennys = luku1 - luku2;
        var kerto = luku1 * luku2;
        var jako = luku1 / luku2;
        Console.WriteLine(luku1 + " + "+ luku2 +" = "+  yhteen);
        Console.WriteLine(luku1 + " - " + luku2 + " = " + vahennys);
        Console.WriteLine(luku1 + " * " + luku2 + " = " + kerto);
        Console.WriteLine(luku1 + " / " + luku2 + " = " + jako);
    }
}