﻿using System.IO;

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
    DateTime elso =Convert.ToDateTime( bontas[1]);
    DateTime utolso = Convert.ToDateTime(bontas[2]);
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








            
    

