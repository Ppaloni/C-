//Chapter 2, exercise 3


//Tämä oli oma ratkaisuni, joka meni läpi, mutta tässä ei käytetty vakiotaulukkoa.
//tehtävänannossa kuitenkin pyydettiin käyttämään vakiotaulukko hyödyksi, josta esimerkki alapuolella.
using System;

class Tehtava2_2

{
    static void Main(String[] args)
{

const int kevät=1;
const int kesä=2;
const int syksy=3;
const int talvi=4;
		Console.WriteLine(syksy);


}
}

//Tämä oli esimerkkiratkaisu tehtävään, joka parempi ratkaisu ehdottomasti.
//Tässä nimetään vuodenajat suoraan heti Vuodenajat vakiotaulukkoon.

using System;

class Ohjelma
{
    enum Vuodenajat : int { kevät = 1, kesä = 2, syksy = 3, talvi = 4 };

    static void Main(string[] args)
    {
        int syksy = (int)Vuodenajat.syksy;
        Console.WriteLine(syksy);
    }
}