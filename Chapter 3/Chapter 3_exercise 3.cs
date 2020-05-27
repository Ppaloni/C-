//Chapter 3, exercise 3


//tässä oma ratkaisuni tehtävään, jossa pyydettiin syöttämään 2 kokonaislukua ja tulostamaan niistä jakojäännös
using System;

class Tehtava3_2
{
    
    static void Main(string[] args)
    {
        
    int luku1, luku2;
        
Console.Write("Anna kaksi kokonaislukua:\n");
        
luku1 = int.Parse(Console.ReadLine());
luku2 = int.Parse(Console.ReadLine());

int jakojaannos = (luku1 % luku2);
		
Console.WriteLine("Lukujen jakojäännös on: " + (jakojaannos));  

		
		
    }
}

//Kurssin esimerkkivastaus:

using System;

class Ohjelma
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Anna kaksi kokonaislukua:");
        var luku1 = Convert.ToInt32(Console.ReadLine());
        var luku2 = Convert.ToInt32(Console.ReadLine());
        var jakojaannos = luku1 % luku2;
        Console.WriteLine("Lukujen jakojäännös on: " + jakojaannos);
    }
}