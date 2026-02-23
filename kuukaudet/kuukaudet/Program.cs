using System;

class Program
{
    static void Main()
    {
        Console.Write("Ole hyvä ja anna kuukausi: ");
        string kk = Console.ReadLine();
        switch(kk)
        {
            case "helmi":
                Console.WriteLine("Kuukaudessa on 27-28 päivää.");
                break;
            case "huhti":
            case "kesä":
            case "syys":
            case "marras":
                Console.WriteLine("Kuukaudessa on 30 päivää.");
                break;
            case "tammi":
            case "maalis":
            case "touko":
            case "heinä":
            case "elo":
            case "loka":
            case "joulu":
                Console.WriteLine("Kuukaudessa on 31 päivää.");
                break;
            default:
                Console.WriteLine("Syöte virheellinen. Sytöä kuukausi lyhesti. Esim. tammi");
                break;
        }
    }
}