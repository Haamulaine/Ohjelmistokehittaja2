using System;

class Program
{
    static void Main()
    {
        int vuosi, kk, paiva, t, min, sek, millis;
            System.DateTime aika = System.DateTime.Now;
        vuosi = aika.Year;
        kk = aika.Month;
        paiva = aika.Day;
        t = aika.Hour;
        min = aika.Minute;
        sek = aika.Second;
        millis = aika.Millisecond;

        Console.WriteLine("Päivämäärä on " + paiva + "." + kk + "." + vuosi);
        Console.WriteLine("Kellonaika on " + t + ":" + min + ":" + sek);
        Console.WriteLine("Millisekunnit ovat: " + millis);
    }
}