//chapter 4, exercise 1

/* Kirjoita C#-kielellä ohjelma, jossa määrittelet muuttujan arvonta ja alustat sen kokonaisluvulla 45. 
Ohjelman pitää pyytää ja lukea luku näppäimistöltä ja verrata sitä muuttujan arvonta arvoon. 
Jos käyttäjän syöttämä luku on yhtäsuuri kuin arvonta, ohjelman pitää tulostaa "Onneksi olkoon, sama luku!" ja lopettaa. 
Muussa tapauksessa ohjelman pitää jatkaa luvun pyytämistä kunnes kierrosten määrä on 5, 
jolloin tulostetaan "Kierroksia 5, lopetetaan ohjelma."*/

using System;

class Tehtava4_1 {
  public static void Main (string[] args) {
int a;
int b;
int c = 0;

    do {
   
     Console.WriteLine("Anna luku:");
     a = int.Parse(Console.ReadLine());
     b = 45;
     c += 1;
     if (a==b){
     Console.WriteLine("Onneksi olkoon, sama luku!"); 
     break; 
     }
    }
     while (a!=b && c!=5);
    if (a!=b){
       Console.WriteLine("Kierroksia 5, lopetetaan ohjelma."); }
  }
}

//Tässä tehtävään vastaus käyttäen while-lauseketta. Kuitenkaan tämä ei mene läpi, 
//koska tehtävänannossa ei sanottu, mutta viopen compiler edellyttää käytetettävän GOTO metodia.

// Tässä muutama muukin mahdollinen  tie ratkaisuun:


		
	/*	
		Console.WriteLine("Anna luku:");
		int a = 45
		int b = int.Parse(Console.ReadLine());
	
			
		
		        if (a==b) {
     Console.WriteLine("Onneksi olkoon, sama luku!");
    }
    else if (a!=b) {
          Console.WriteLine("Anna luku:");
    b = int.Parse(Console.ReadLine());
  }
				
*/		
		
/* using System;

class Tehtava4_1 {
  public static void Main (string[] args) {

    
    Console.WriteLine("Anna luku:");
    int a = int.Parse(Console.ReadLine());
    int b = 45;

    while (a!=b) {
        Console.WriteLine("Anna luku:");
        a = int.Parse(Console.ReadLine());
    }
  }
}
*/
		
using System;

class Tehtava4_1 {
    
    static void Main(string[] args) {	
		
		
//tässä määritellään muuttuja a, joka on meidän tehtävänannossa saamamme numero 45.
// Huomaa switch koodi on vielä keskeneräinen


int a = 45;
//tässä määritellään alku niminen-viite.
alku:
		
Console.WriteLine("Anna luku:";
i = int.Parse(Console.ReadLine());

switch(a) {
	case int i when ( i == a):
	Console.WriteLine("Onneksi olkoon, sama luku!");
	break;
	
	case int i when (i != a):
	Console.WriteLine("Anna luku:");
	i = int.Parse(Console.Readline());
	
	
case int i when (i != a):
	Console.WriteLine("Anna luku:");
	i = int.Parse(Console.Readline());
	
case int i when (i != a):
	Console.WriteLine("Anna luku:");
	i = int.Parse(Console.Readline());
	
case int i when (i != a):
	Console.WriteLine("Anna luku:");
	i = int.Parse(Console.Readline());
	break;

	
	
}
		
				  
				  
				  

		}
		
    } 


//Tässä Viopen esimerkki ratkaisu:
//Tämä esimerkki erosi ratkaisusta vain käytännössä tuolla "goto alku;" komennolla ja "alku:" määritelyllä koodin alussa.

using System;

class Ohjelma
{
    
    static void Main(string[] args)
    {
        int kierros = 0;
    alku:
        kierros++;
        int arvonta = 45;
        Console.WriteLine("Anna luku:");
        var luku = Convert.ToDouble(Console.ReadLine());

        if (luku == arvonta)
        {
            Console.WriteLine("Onneksi olkoon, sama luku!");
        }
        else if (kierros == 5)
        {
            Console.WriteLine("Kierroksia 5, lopetetaan ohjelma.");
        }
        else
        {
            goto alku;
        }
    }
}

