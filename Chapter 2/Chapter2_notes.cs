Ohjausmerkki            Kuvaus
\'                      Heittomerkki(Single Quote)
\""                     Lainausmerkki(Double Quote)
\\                      Kenoviiva(Backlash)
\0                      Null-merkki(huom.: ei ole sama kuin C# null arvo)
\a                      Varoitus(alert)
\b                      Askelpalautus(Backspace)
\f                      Sivun kelaus(Form feed)
\n                      Uusi rivi(New line)
\r                      Vaunun palautus(Carriage return)
\t                      Sarkain(Horizontal tab)
\v                      Pystysarkain(Vertical tab)

Seuraavassa chart-tyyppinen muuttuja alustetaan erikoismerkeillä ja heksadesimaaliluvulla;

01 charpSarkain='\v';
02 char heksaLuku='\x0af';


//string-tyyppi on itse asiassa C#-kieleen valmiiksi kirjoitettu luokka (class), 
//johon myös kuuluu paljon erilaisia sisäänrakennettuja toimintoja (metodeja) tekstin käsittelemiseksi. string-tyyppiä käytetään merkkijonojen käsittelemiseksi. 
//Merkkijonot ovat Unicode-merkkiyhdistelmiä, jotka voivat muodostaa sanoja tai lauseita. string-muuttujien arvot aina laitetaan lainausmerkkien (" ") sisään, kuten:

01 string tervehdys="Heippa sinne!";

//string-tyyppinen muuttujat voidaan yhdistää +-operaattorin avulla, kuten:

01 //seuraavassa merkkijonoon laitetaan sarkain, teksti
02 //ja rivin vaihto
03 string kuvaus1="\tNyt on kesä\n";
04
05 //seuraavassa kolme  tekstipätkää liitetään toisiinsa.
06 string kuvaus2 ="Tänään oli" + "aurinkoinen päivä...." + "\n";

//Totuusarvo-tyyppiä (bool) käytetään Boolen (Boolean) logiikan tosi (true)- ja epätosi (false)-arvojen säilyttämiseksi.
01 //Tässä määritellään muuttujat x ja y.
02 bool x, y;
03
04 //tässä x alustetaan true arvolla.
05 x=true;
06
07 /Tässä y alustetaan false arvolla.
08 u=false;

//Kuten aikaisemmin mainittiin, ennen muuttujan käyttöä se tulee esitellä (declare). Muuttujan esittely vaatii sen tyypin ja nimen määräämistä. 
/*Tyyppi voi olla C#-kielen mikä tahansa ennalta määritellyistä. 
Muuttujan nimi ei saa sisältää ääkkösiä eivätkä ne saa olla samoja kuin C#:n varatut sanat. Muuttujan nimi voi alkaa jollakin kirjaimella tai alaviivalla (_) ja siihen voi kuulua kirjaimia, 
lukuja sekä alaviivoja. C#:ssa käytäntönä on se, että muuttujan nimi aloitetaan pienellä kirjaimella, mutta nimessä esiintyvä uusi sana kirjoitetaan isolla alkukirjaimella, kuten henkiloPalkka. 
Muuttuja voidaan ensin esitellä ja sitten alustaa eri rivillä, tai alustaa esittelynsä yhteydessä samalla rivillä.

Muuttuja pitää alustaa ennen sen käyttöä. Jos ohjelmassa yritetään käyttää muuttujaa ennen sen alustusta, se aiheuttaa virheen ennen ohjelman ajamista jo käännösvaiheessa!*/
01 // tässä esitellään muuttuja palkka.
02 float palkka;
03
04 // seuraava aiheuttaa virheen koska muuttajalle palkka
05 // ei ole määritelty alkuarvoa!
06 palkka=1.05*palkka;

//C# on täysin olio-pohjainen (object oriented) kieli.
//Tämä tarkoittaa, että kaikki mahdolliset ohjelman toiminnot pitää sisällyttää johonkin luokkaan (class).
//Ohjelma koostuu yhdestä pääluokasta (main class) ja mahdollisesti muista luokista.
//Pääluokka on se, joka sisältää ainakin vakionimisen Main()-metodin, josta ohjelman suoritus alkaa.
//Luokkien sisällöt laitetaan {}-merkkiyhdistelmän sisään.
//Main()- ja muiden metodien sisällöt myös laitetaan {}-merkkiyhdistelmän sisään.
//C#-kielessä isot ja pienet kirjaimet ovat eriarvoisia. 
//Tämä tarkoittaa sitä, että sekä C#-kielen omat varatut sanat, että käyttäjän luomat uudet sanat pitää aina kirjoittaa siten, kuin ne alun perin määriteltiin.
//C#-ohjelmien yleinen rakenne yksinkertaisimmillaan näyttää seuraavalta:
01 class ohjelman_pääluokan_nimi
02 {
03
04 public static void Main(string[]args)
05 {
06 //Tähän tulee ohjelman lauseet.
07 }
08 }

//Olio-ohjelmoinnissa (object-oriented programming) ohjelmointiongelmien ratkaisemiseksi määritellään luokkia (classes), jotka sisältävät toisiinsa loogisesti liittyvää tietoa ja toiminnallisuutta.
//Tietojen säilyttämiseksi käytetään muuttujia (variables) ja toimintojen toteuttamiseksi käytetään metodeja (methods).
//Ohjelmassa luodaan luokista instansseja (instances), eli olioita (objects), joiden yhteistoiminnalla ongelmat ratkaistaan.
//Seuraavaksi kirjoitetaan meidän ensimmäinen C#-ohjelma. 
//Ohjelman pääluokan nimi on Esimerkki2_1, jonka Main()-metodiin laitetaan lauseet, joilla tulostetaan tietokoneen näytölle "Hei maailma!"-teksti sekä tämän hetken päivämäärä ja aika.

01 //Tässä otetaan käyttöön System-kirjasto, joka
02 //sisältää mm.komennot tekstin näytölle tulostamiseksi
03 using System;
04
05 //seuraavassa määritellään ohjelman pääluokka,
06 //jonka nimi on Esimerkki2_1.
07 class Esimerkki2_1
08 {
09 //Ohjelman suoritus alkaa tästä.
10 public static void Main(string[]args)
11 {
12 //tässä tulostetaan näytölle "Hei maailma!".
13 Console.WriteLine("Hei maailma!");
14
15 //Seuraavassa tulostetaan näytölle tekstipätkä sekä
16 // tämän hetken päivämäärä ja aika.
17 Console.WriteLine("Nyt on" + DateTime-Now);
18 }
19}


// Jäätiin chapter 2, 10/22 -> Ohjelman ajaminen

