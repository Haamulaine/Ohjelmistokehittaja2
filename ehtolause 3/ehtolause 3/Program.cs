using System;

class Program 
{
    static void Main() 
    {
        Console.Write("Anna kokonaisluku (0-9): ");
        int luku = int.Parse(Console.ReadLine());

        switch(luku) 
        {
            case 0:
                Console.WriteLine("nolla");
                break;
            case 1:
                Console.WriteLine("yksi");
                break;
            case 2:
                Console.WriteLine("kaksi");
                break;
            case 3:
                Console.WriteLine("kolme");
                break;
            case 4:
                Console.WriteLine("neljä");
                break;
            case 5:
                Console.WriteLine("viisi");
                break;
            case 6:
                Console.WriteLine("kuusi");
                break;
            case 7:
                Console.WriteLine("seitsemän");
                break;
            case 8:
                Console.WriteLine("kahdeksan");
                break;
            case 9:
                Console.WriteLine("yhdeksän");
                break;
            default:
                Console.WriteLine("Virhe: syötä luku 0-9 väliltä.");
                break;
        }
    }
}