using System;

namespace MacierzLiczbyNaPrzekatnej
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            double[,] tab = new double[n, n];



            Macierz macierzatko = new Macierz();

            macierzatko.WczytajDane(tab);
            macierzatko.PrzetworzDane(tab);
            macierzatko.WyswietlDane(tab);
        }
    }
}
