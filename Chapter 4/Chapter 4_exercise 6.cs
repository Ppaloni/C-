//Chapter 4, exercise 6

/* Kirjoita C#-kielellä ohjelma, joka pyytää ja lukee ylärajan ja 
tulostaa alkuluvut (prime numbers), jotka ovat sitä pienempiä tai yhtä suuri 
kuin se itse. Vihje: alkuluku on positiivinen kokonaisluku, 
joka on jaollinen vain ykkösellä ja itsellään. */

//Googletetaan kappaleen lukemisen jälkeen "C# prime numbers" ja lähdetään siitä liikkeelle.
//Tähän aika paljon tuli käytettyä googlea apuna, nämä prime numberit ei ollu iha tutuimmasta päästä

//Ratkaisu tehtävään:
using System;  
public class Tehtava4_6 
{  
    public static void Main()
{
    int num,i,ctr,raja;
    
    Console.WriteLine("Anna yläraja: ");
    raja = Convert.ToInt32(Console.ReadLine());     
  
    for(num = 1;num<=raja;num++)
       {
         ctr = 0;

         for(i=2;i<=num/2;i++)
            {
             if(num%i==0){
                 ctr++;
                 break;
             }
        }
        
         if(ctr==0 && num!= 1)
             Console.Write("{0} ",num);
    }
    Console.Write("\n"); 
  } 
}

//Viopen esimerkkivastaus:


class Ohjelma
{
    static void Main(string[] args)
    {
        Console.WriteLine("Anna yläraja:");
        int raja = Convert.ToInt32(Console.ReadLine());

        for (long i = 2; i <= raja; i++)
        {
            bool onAlkuluku = true;
            for (long j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    onAlkuluku = false;
                    break;
                }
            }
            if (onAlkuluku)
            {
                Console.WriteLine(i);
            }
        }
    }
}