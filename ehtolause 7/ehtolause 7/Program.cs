using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Anna luku 0-999 välillä:");
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 0 && number <= 999)
        {
            string numberInWords = NumberToWords(number);
            Console.WriteLine(numberInWords);
        }
        else
        {
            Console.WriteLine("Virheellinen luku!");
        }
    }

    static string NumberToWords(int number)
    {
        if (number == 0)
            return "nolla";

        string[] units = { "", "yksi", "kaksi", "kolme", "neljä", "viisi", "kuusi", "seitsemän", "kahdeksan", "yhdeksän" };
        string[] teens = { "kymmenen", "yksitoista", "kaksitoista", "kolmetoista", "neljätoista", "viisitoista", "kuusitoista", "seitsemäntoista", "kahdeksantoista", "yhdeksäntoista" };
        string[] tens = { "", "", "kaksikymmentä", "kolmekymmentä", "neljäkymmentä", "viisikymmentä", "kuusikymmentä", "seitsemänkymmentä", "kahdeksankymmentä", "yhdeksänkymmentä" };

        string words = "";

        //sadat
        if (number >= 100)
        {
            int hundreds = number / 100;
            words += units[hundreds] + "sataa";
            number %= 100;
            if (number > 0) words += " ";
        }

        //kymmenet ja yksiköt
        if (number >= 20)
        {
            int ten = number / 10;
            words += tens[ten];
            number %= 10;
            if (number > 0) words += " ";
        }

        else if (number >= 10)
        {
            words += teens[number - 10];
            number = 0;
        }

        //yksiköt
        if (number > 0) 
        {
            words += units[number];
        }

        return words;
    }
}