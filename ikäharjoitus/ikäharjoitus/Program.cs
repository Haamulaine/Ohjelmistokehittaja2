class Program
{
    static void Main()
    {
        Console.Write("Ole hyvä ja syötä ikäsi: ");
        int ika = int.Parse(Console.ReadLine());
        if (ika < 15)
        {
            Console.WriteLine("Saat ajaa polkupyörää.");
        }
        else if (ika < 18)
        {
            Console.WriteLine("Saat ajaa mopoa.");
        }
        else
        {
            Console.WriteLine("Saat ajaa autoa.");
        }
    }
}