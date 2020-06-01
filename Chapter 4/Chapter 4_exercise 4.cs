//Chapter 4_exercise 4

//Tässä ratkaisu tehtävään, kyseessähän oli fibonacci

using System;  
public class Tehtava4_4 {  
   public static void Main(string[] args) {  
	   
      int num1 = 1, num2 = 1, num3, i, n;    
         
      n = 20;
         

      Console.WriteLine(num1); 
      Console.WriteLine(num2); 
	   
      for(i=2;i<n;++i) {    
         num3 = num1 + num2;    
         Console.WriteLine(num3);    
         num1 = num2;    
         num2 = num3;    
      }    
   }  
}

//Tässä vielä Viopen esimerkkivastaus:

using System;

class Ohjelma
{
    static void Main(string[] args)
    {
        int luku = 1;
        int edellinen_luku = 0;

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(luku);
            luku = luku + edellinen_luku;
            edellinen_luku = luku - edellinen_luku;
        }
    }
}