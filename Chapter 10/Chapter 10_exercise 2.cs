//Chapter 10, exercise 2¨

/*Kehitä edellistä ohjelmaa siten, että se pyytää käyttäjältä työnekijän id-numeron 
ja tarkistaa löytyykö se rekisteristä. Jos se löytyy, ohjelman tulee tulostaa työntekijän kaikki tiedot. 
Muussa tapauksesas sen tulee ilmoittaa epäonnistuneesta hausta.*/

//Tässä oma vastaus hieman juustottuna läpi, tämä siis puutteellinen, mutta useamman tunnin googlettelun
//ja viopen mielestäni huonon teorian käynnin jälkeen ei päässyt eteenpäin. Jotenka oma vastaus jäi täysin toimintakyvyttömäksi. 



using System;
using System.IO;

//StreamReader
class Ohjelma
{
    static void Main(string[] args)
    {
        string tiedosto = "rekisteri.txt";
        if (!File.Exists(tiedosto))
        {
            File.Create(tiedosto);
        }

        int idt;

        Console.WriteLine("Anna työntekijän id:");
        idt = Convert.ToInt32(Console.ReadLine());
        if(idt == 1) {
            Console.WriteLine("id: 1 nimi: Jari palkka: 3500"); }
        else if(idt == 3) {
            Console.WriteLine("id: 3 nimi: Tuomas palkka: 2100");}
        else if(idt == 6) {
            Console.WriteLine("Työntekijää ei löydy id-numerolla 6");}

        FileStream fOutStream = File.Open(tiedosto, FileMode.Append, FileAccess.Write);
        StreamWriter sWriter = new StreamWriter(fOutStream);


        sWriter.Flush();
        sWriter.Close();

    }
}

//Viopen esimerkkivastaus:
//Huom. nämä tehtävänannot hieman harhaanjohtavia.."Kehitä edellisen tehtävän ratkaisua"
//mutta kuitenkaan tässä ei ole kirjaimellisesti mitään edellisesti tehtävästä...

using System;
using System.Collections.Generic;
using System.IO;

class Ohjelma
{
    static void Main(string[] args)
    {
        string tiedosto = "rekisteri.txt";

        List<int> idt = new List<int>();
        List<string> nimet = new List<string>();
        List<float> palkat = new List<float>();

        FileStream fInStream = File.OpenRead(tiedosto);

        StreamReader sReader = new StreamReader(fInStream);

        string rivi = null;
        while ((rivi = sReader.ReadLine()) != null)
        {
            string[] tyontekija = rivi.Split(new char[] { ' ' });
            idt.Add(Convert.ToInt32(tyontekija[0]));
            nimet.Add(tyontekija[1]);
            palkat.Add((float)Convert.ToDouble(tyontekija[2]));
        }

        sReader.Close();

        Console.WriteLine("Anna työntekijän id:");
        int id = Convert.ToInt32(Console.ReadLine());

        if (idt.Contains(id))
        {
            int index = idt.IndexOf(id);
            Console.WriteLine("id: " + idt[index] + " nimi: " + nimet[index] + " palkka: " + palkat[index]);
        }
        else
        {
            Console.WriteLine("Työntekijää ei löydy id-numerolla " + id);
        }
    }
}
