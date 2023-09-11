using System;
using System.IO;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> lista = new List<string>();

//1. feladat
string[] forras =File.ReadAllLines("balkezesek_jav.csv");
//2. feladat
    for (int i = 0; i < forras.Length; i++)
			{
    string[] bontas = forras[i].Split(';');
    string nev = bontas[0];
    int elso =Convert.ToDateTime( bontas[1]);
    int utolso = Convert.ToDateTime(bontas[2]);
    int suly = Convert.ToInt32(bontas[3]);
    int magassag= Convert.ToInt32(bontas[4]);


    lista.Add(bontas[0]);
    lista.Add(bontas[1].ToString());
    lista.Add(bontas[2].ToString());
    lista.Add(bontas[3]);
    lista.Add(bontas[4]);
}

//3. feladat

int elemszam=lista.Count;

Console.WriteLine(elemszam);

//4. feladat
int inch = 254/100;

for (int j = 0; j  <lista.Count; j++)
{
    if (lista.ElementAt)
    {

    }
}
//5.feladat

Console.WriteLine("adjon meg egy 1990 és 1999 közötti évszámot");

int datum=Console.ReadLine(datum.ToString());


//6.feladat

if (datum > 1990 && datum < 1999)
{
    Console.WriteLine("Hibás adat, kérek egy 1990 és 1999 közötti számot")
;
}
do
{
	Console.WriteLine("Hibás adat, kérek egy 1990 és 1999 közötti számot")
} while (datum > 1990 && datum < 1999);









