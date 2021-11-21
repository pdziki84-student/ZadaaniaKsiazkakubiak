
using System;

namespace TabliceDwuwymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] macierz = new int[10,10];
            int suma = 0;

            for (int i = 0; i < macierz.GetLength(0); i++)
            {
                for (int j = 0; j < macierz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        macierz[i,j] = 1;
                        suma += 1;
                    }
                    else
                    {
                        macierz[i, j] = 0;
                    }
                }
            }

            Console.WriteLine("\n\nWyświetlanie wyników\n\n");


            for (int i = 0; i < macierz.GetLength(0); i++)
            {
                for (int j = 0; j < macierz.GetLength(1); j++)
                {
                    Console.Write(macierz[i,j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine($"suma na przekątnej równa się: {suma}");


        }
    }
}
