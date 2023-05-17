using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Vali meetod:");
        Console.WriteLine("1. Esimene meetod - loob faili desktopile");
        Console.WriteLine("2. Teine meetod - loob faili ja kirjutab sisu");
        Console.WriteLine("3. Kolmas meetod - loob faili ja lisab faili URL-i");
        Console.WriteLine();

        int valik = int.Parse(Console.ReadLine());

        if (valik == 1)
        {
            EsimeneMeetod();
        }
        else if (valik == 2)
        {
            TeineMeetod();
        }
        else if (valik == 3)
        {
            KolmasMeetod();
        }
        else
        {
            Console.WriteLine("Vigane valik.");
        }
    }

    static void EsimeneMeetod()
    {
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string failiTee = Path.Combine(desktop, "minu_fail.txt");

        File.Create(failiTee);
        Console.WriteLine("Fail loodud desktopile.");
    }

    static void TeineMeetod()
    {
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string failiTee = Path.Combine(desktop, "minu_fail.txt");

        Console.WriteLine("Sisesta faili sisu:");
        string sisu = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(failiTee))
        {
            writer.WriteLine(sisu);
        }

        Console.WriteLine("Fail loodud ja sisu lisatud.");
    }

    static void KolmasMeetod()
    {
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string failiTee = Path.Combine(desktop, "minu_fail.txt");
        string valeFailiTee = "https://www.failiteenus.ee/failid/minu_fail.txt";

        using (StreamWriter writer = new StreamWriter(failiTee))
        {
            writer.WriteLine(valeFailiTee);
        }

        Console.WriteLine("Fail loodud ja vale URL lisatud.");
    }
}

