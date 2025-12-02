using System;

class Program
{
    static void Main()
    {
        string tekst = "programowanie";
        string odwrocony = "";

        for (int i = tekst.Length-1; i >= 0; i--) // miejsce liczy sie od zera a tu było liczone od 1 
        {
            odwrocony += tekst[i];
        }

        Console.WriteLine(odwrocony);
    }
}