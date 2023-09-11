using System.IO;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> lista = new List<string>();


string[] forras =File.ReadAllLines("balkezesek_jav.csv");

    for (int i = 0; i < forras.Length; i++)
			{
    string[] bontas = forras[i].Split(';');
    string nev = bontas[0];
    DateTime elso =Convert.ToDateTime( bontas[1]);
    DateTime utolso = Convert.ToDateTime(bontas[2]);
    int suly = Convert.ToInt32(bontas[3]);
    int magassag= Convert.ToInt32(bontas[4]);

}
            
    

