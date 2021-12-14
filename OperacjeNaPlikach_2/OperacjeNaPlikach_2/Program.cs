using System;
using System.IO;

namespace OperacjeNaPlikach_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;

            int[,] a = new int[n, n];
            int[,] b = new int[n, n];
            int[,] c = new int[n, n];


            PlikTekstwowy nowyPlik = new PlikTekstwowy();
            MatrixZmianaWierszNaKolumne matrix = new MatrixZmianaWierszNaKolumne();

            // nowyPlik.wczytaj_dane(dane,  n);
            // nowyPlik.zapisz_dane_do_pliku(dane, n);
            // nowyPlik.wczytaj_dane_z_pliku(dane1, n);


            matrix.wczytaj_dane(a, n);
            matrix.przetworz_dane(a, b, n);
            matrix.zapisz_dane_do_pliku(b, n);
            matrix.wczytaj_dane_z_pliku(c, n);
        }
    }
}
