using System;

namespace ObliczanieRownaniaKwadratowego
{
    class Program
    {
        static void Main(string[] args)
        {
            Trojmian rownanie = new Trojmian();

            rownanie.WczytajDane();
            rownanie.PrzetworzDane();
            rownanie.WyswietlDane();
        }
    }
}
