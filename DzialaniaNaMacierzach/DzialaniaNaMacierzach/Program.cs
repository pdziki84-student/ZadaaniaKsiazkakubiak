using System;

namespace DzialaniaNaMacierzach
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[,] macierzA = new int[n,n];
            int[,] macierzB = new int[n, n];
            int[,] macierzC = new int[n, n];
            int[,] macierzD = new int[n, n];
            int[,] macierzE = new int[n, n];


            for (int i = 0; i < macierzA.GetLength(0); i++)
            {
                for (int j = 0; j < macierzA.GetLength(1); j++)
                {
                    macierzA[i, j] = 1;
                }
            }

            for (int i = 0; i < macierzB.GetLength(0); i++)
            {
                for (int j = 0; j < macierzB.GetLength(1); j++)
                {
                    macierzB[i, j] = 2;
                }
            }

            Console.WriteLine("\n\nWyswietlanie zawartosci macierzy A\n\n");
            for (int i = 0; i < macierzA.GetLength(0); i++)
            {
                for (int j = 0; j < macierzA.GetLength(1); j++)
                {
                    Console.Write(macierzA[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nWyswietlanie zawartosci macierzy B\n\n");

            for (int i = 0; i < macierzB.GetLength(0); i++)
            {
                for (int j = 0; j < macierzB.GetLength(1); j++)
                {
                    Console.Write(macierzB[i, j] + " ");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < macierzB.GetLength(0); i++)
            {
                for (int j = 0; j < macierzB.GetLength(1); j++)
                {
                    macierzC[i, j] = macierzA[i, j] + macierzB[i, j];
                }
                
            }


            Console.WriteLine("\n\nDodawanie obu macierzy\n\n");

            for (int i = 0; i < macierzC.GetLength(0); i++)
            {
                for (int j = 0; j < macierzC.GetLength(1); j++)
                {
                    Console.Write(macierzC[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nRóżnica między macierzami\n\n");

            for (int i = 0; i < macierzD.GetLength(0); i++)
            {
                for (int j = 0; j < macierzD.GetLength(1); j++)
                {
                    macierzD[i, j] = macierzB[i, j] - macierzA[i, j];
                }

            }

            for (int i = 0; i < macierzD.GetLength(0); i++)
            {
                for (int j = 0; j < macierzD.GetLength(1); j++)
                {
                    Console.Write(macierzD[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
