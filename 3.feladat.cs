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
    lista.Add(bontas[1]);
    lista.Add(bontas[2]);
    lista.Add(bontas[3]);
    lista.Add(bontas[4]);
}

//3. feladat

int elemszam=lista.Count;

Console.WriteLine(elemszam);

int inch = bontas[4] % 2.54;




            
    

