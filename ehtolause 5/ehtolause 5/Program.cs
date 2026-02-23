using System;

class Program 
{
    static void Main()
    {
        Console.WriteLine("Mitä haluat syöttää?");
        Console.WriteLine("1 - Kokonaisluku");
        Console.WriteLine("2 - Double-luku");
        Console.WriteLine("3 - Merkkijono");

        Console.Write("Valintasi: ");

        string valinta = Console.ReadLine();

        switch(valinta)
        {
            case "1":
                Console.Write("Anna kokonaisluku: ");
                int kokonaisluku = int.Parse(Console.ReadLine());
                kokonaisluku++;
                Console.WriteLine("Tulos: " + kokonaisluku);
                break;
            case "2":
                Console.Write("Anna double-luku: ");
                double desimaali = double.Parse(Console.ReadLine());
                desimaali++;
                Console.WriteLine("Tulos: " + desimaali);
                break;
            case "3":
                Console.Write("Anna merkkijono: ");
                string teksti = Console.ReadLine();
                teksti = teksti + "*";
                Console.WriteLine("Tulos: " + teksti);
                break;
            default:
                Console.WriteLine("Virheellinen valinta!");
                break;
        }
    }
}