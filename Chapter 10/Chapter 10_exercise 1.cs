
//Chapter 10, exercise 1

/*Kirjoita C#-kielellä ohjelma, joka luo tiedoston rekisteri.txt. 
Tämän jälkeen ohjelman tulee pyytää kolmen työntekijän tietoja; id (int), nimi (string) 
ja palkka (float) ja kirjoittaa ne rekisteriin. Anna tiedostoon seuraavat tiedot:

id: 1 | nimi: Jari | palkka: 3500
id: 2 | nimi: Matti | palkka: 4800
id: 3 | nimi: Tuomas | palkka: 2100Kirjoita C#-kielellä ohjelma, 
joka luo tiedoston rekisteri.txt. Tämän jälkeen ohjelman tulee pyytää kolmen työntekijän tietoja; id (int), nimi (string) ja palkka (float) ja kirjoittaa ne rekisteriin. Anna tiedostoon seuraavat tiedot:

id: 1 | nimi: Jari | palkka: 3500
id: 2 | nimi: Matti | palkka: 4800
id: 3 | nimi: Tuomas | palkka: 2100*/



//Tässä oma ratkaisu tehtävään, viope päästi läpi hieman vaillinaisella ratkaisulla
//puuttuu omasta siis vielä taulukko, johon kysytyt tiedot tallentuisivat
using System;
using System.IO;

class tehtava10_1
{
    static void Main(string[] args)
    {
        string tiedosto="C:\\Temp\\rekisteri.txt";
        File.Create(tiedosto);
        
		int id;
		string nimi;
		int palkka;
		
        Console.WriteLine("Anna kolmen työntekijän tiedot (id, nimi, palkka):");
        
        for(int i = 0; i < 3; i++){
            Console.WriteLine("Anna id:");
			id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna nimi:");
			nimi = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Anna palkka:");
			palkka = Convert.ToInt32(Console.ReadLine());
        }
        

    }
}

//Viopen esimerkki vastaus:

using System;
using System.IO;

class Ohjelma
{
    static void Main(string[] args)
    {
        string tiedosto = "rekisteri.txt";
        if (!File.Exists(tiedosto))
        {
            File.Create(tiedosto);
        }

        int[] idt = new int[3];
        string[] nimet = new string[3];
        float[] palkat = new float[3];

        Console.WriteLine("Anna kolmen työntekijän tiedot (id, nimi, palkka): ");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Anna id: ");
            idt[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Anna nimi: ");
            nimet[i] = Console.ReadLine();

            Console.WriteLine("Anna palkka: ");
            palkat[i] = (float)Convert.ToDouble(Console.ReadLine());
        }

        FileStream fOutStream = File.Open(tiedosto, FileMode.Append, FileAccess.Write);
        StreamWriter sWriter = new StreamWriter(fOutStream);
        for (int i = 0; i < nimet.Length; i++)
        {
            sWriter.WriteLine(idt[i] + " " + nimet[i] + " " + palkat[i]);
        }

        sWriter.Flush();
        sWriter.Close();
    }
}
