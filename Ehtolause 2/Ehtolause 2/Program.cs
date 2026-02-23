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

        int suurin = a;

        if (b > suurin) 
        {
            suurin = b;
        }

        if (c > suurin) 
        {
            suurin = c;
        }

        Console.WriteLine("Suurin luku on: " + suurin);
    }
}