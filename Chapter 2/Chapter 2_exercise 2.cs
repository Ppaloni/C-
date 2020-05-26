//Chapter 2, exercise 2

using System;

class Tehtava2_2

{
    static void Main(String[] args)
{


string[] tuoteHinnat = new string[3];
tuoteHinnat[0] = " 928,90€";
tuoteHinnat[1] = " 349€";
tuoteHinnat[2] = " 99,80€";

string[] tuoteNimi = new string[3]; 
tuoteNimi[0] = "MacBook Air";
tuoteNimi[1] = "Jolla";
tuoteNimi[2] = "Nokia";

Console.WriteLine(tuoteNimi[0] + tuoteHinnat[0]);
Console.WriteLine(tuoteNimi[1] + tuoteHinnat[1]);
Console.WriteLine(tuoteNimi[2] + tuoteHinnat[2]);
}
}