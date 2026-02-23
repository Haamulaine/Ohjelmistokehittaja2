using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Anna x:n arvo: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Anna y:n arvo: ");
        int y = int.Parse(Console.ReadLine());

        int tulos = x *= y;

        Console.WriteLine("Tulos: " + tulos);
    }

}