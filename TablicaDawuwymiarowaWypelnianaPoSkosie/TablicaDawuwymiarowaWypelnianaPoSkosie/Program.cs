using System;

namespace TablicaDawuwymiarowaWypelnianaPoSkosie
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[,] macierz = new int[n, n];
            int suma = 0;

            for (int i = 0; i < 10; i++) //kolumny
            {
                for (int j = 0; j < 10; j++)  // wiersze
                {
                    if (n == i + j + 1)
                    {
                        macierz[i, j] = 1;
                        suma += 1;
                    }
                    else
                    {
                        macierz[i, j] = 0;
                    }

                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(macierz[i, j] +" ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n\nna przekatnej cyfry od 0 do 9");

            int n1 = 10;
            int[,] macierz1 = new int[n, n];
            int suma1 = 0;

            for (int i = 0; i < 10; i++) //kolumny
            {
                for (int j = 0; j < 10; j++)  // wiersze
                {
                    if (n1 == i + j + 1)
                    {
                        macierz1[i, j] = i;
                        suma1 += i;
                    }
                    else
                    {
                        macierz1[i, j] = 0;
                    }

                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(macierz1[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine($"Suma = {suma1}");
        }
    }
}
