using System;

class Program
{
    static void Main()
    {
        Console.Write("Anna ensimmäinen kokonaisluku: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Anna toinen kokonaisluku: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Anna kolmas kokonaisluku: ");
        int c = int.Parse(Console.ReadLine());

        Console.Write("Anna neljäs kokonaisluku: ");
        int d = int.Parse(Console.ReadLine());

        Console.Write("Anna viides kokonaisluku: ");
        int e = int.Parse(Console.ReadLine());

        int suurin = a;

        if (b > suurin)
        {
            suurin = b;
        }

        if (c > suurin)
        {
            suurin = c;
        }

        if (d > suurin) 
        {
            suurin = d;
        }

        if (e > suurin) 
        {
            suurin = e;
        }

        Console.WriteLine("Suurin luku on: " + suurin);
    }
}