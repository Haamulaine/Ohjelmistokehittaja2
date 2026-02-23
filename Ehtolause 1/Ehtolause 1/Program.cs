using System;

class Program 
{
    static void Main() 
    {
        Console.Write("Anna ensimmäinen luku: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Anna toinen luku: ");
        int b = int.Parse(Console.ReadLine());

        //Ehtolause

        if (a > b) 
        {
            int temp = a;
            a = b;
            b = temp;
        }

        Console.WriteLine("Luvut järjestyksessä:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}