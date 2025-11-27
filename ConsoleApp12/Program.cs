using System;

class Program
{
    static void Main()
    {
        string tekst = "programowanie";
        string odwrocony = "";

        for (int i = tekst.Length; i >= 0; i--)
        {
            odwrocony += tekst[i];
        }

        Console.WriteLine(odwrocony);
    }
}