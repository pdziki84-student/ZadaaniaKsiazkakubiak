using System;

namespace SortowanieBabelkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Sortowanie babelki = new Sortowanie();

            int n = 6;
            int[] liczby = new int[n];
            //liczby[0] = -3;
            //liczby[1] = 72;
            //liczby[2] = -33;
            //liczby[3] = 5;
            //liczby[4] = 0;
            //liczby[5] = 30;

            babelki.WczytajDane(liczby);
            babelki.PrzetworzDane(liczby);
            babelki.WyswietlDane(liczby);
        }
    }
}
