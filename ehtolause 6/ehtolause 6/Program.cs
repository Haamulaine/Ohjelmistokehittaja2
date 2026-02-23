using System;

class Program
{
    static void Main()
    {
        Console.Write("Anna pisteet 0-9: ");
        int pisteet = int.Parse(Console.ReadLine());
        int bonus;

        if (pisteet >= 1 && pisteet <= 3)
        {
            bonus = pisteet * 10;
            Console.WriteLine("Bonuspisteet: " + bonus);
        }

        else if (pisteet >= 4 && pisteet <= 6)
        {
            bonus = pisteet * 100;
            Console.WriteLine("Bonuspisteet: " + bonus);
        }

        else if (pisteet >= 7 && pisteet <= 9)
        {
            bonus = pisteet * 1000;
            Console.WriteLine("Bonuspisteet: " + bonus);
        }

        else
        {
            Console.WriteLine("Virhe: pisteet ovat virheellisellä alueella.");
        }
    }
}