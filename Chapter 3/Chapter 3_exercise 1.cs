//Chapter 3, exercise 1


//tässä oma ratkaisuni. Tehtävänannosta puuttui täysin tuotteiden lukumäärä,
//sitä siis ei oltu kerrottu lainkaan. Näin ollen ei ollut mahdollista toteuttaa
//ratkaisua niinkuin esimerkki vastauksessa. 
using System;

class Tehtava3_1 {
	
	
    
static void Main(String[] args) {

decimal[] tuoteHinta = new decimal[3];
tuoteHinta[0] = 7.96m;
tuoteHinta[1] = 72.0m;
tuoteHinta[2] = 99.90m;

int[] tuoteLkm = new int[3]; 
tuoteLkm[0] = 1;
tuoteLkm[1] = 2;
tuoteLkm[2] = 3;
	
decimal[] tuoteYhthinta = new decimal[3]; 
tuoteYhthinta[0] = (tuoteHinta[0] * tuoteLkm[0]);
tuoteYhthinta[1] = (tuoteHinta[1] * tuoteLkm[1]);
tuoteYhthinta[2] = (tuoteHinta[2] * tuoteLkm[1]);


Console.WriteLine("Tuote 1:" + " " + tuoteHinta[0]);
Console.WriteLine("Tuote 2:" + " " + tuoteHinta[1]);
Console.WriteLine("Tuote 3:" + " " + tuoteHinta[2]);	
	
}
}

//tässä esimerkkivastaus, vaikka tehtäväannosta puuttui täysin nuo tuotteiden LKM:t

using System;

class Ohjelma
{
    
    static void Main(string[] args)
    {
        decimal[] tuoteHinta = new decimal[3] { 1.99M, 24.0M, 99.90M };
        int[] tuoteLkm = new int[3] { 4, 3, 1 };
        decimal[] tuoteYhtHinta = new decimal[3] { tuoteHinta[0] * tuoteLkm[0], tuoteHinta[1] * tuoteLkm[1], tuoteHinta[2] * tuoteLkm[2] };

        Console.WriteLine("Tuote 1: " + tuoteYhtHinta[0]);
        Console.WriteLine("Tuote 2: " + tuoteYhtHinta[1]);
        Console.WriteLine("Tuote 3: " + tuoteYhtHinta[2]);
    }
}
