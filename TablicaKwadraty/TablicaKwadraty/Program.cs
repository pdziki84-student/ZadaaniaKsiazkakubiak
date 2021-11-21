
using System;

namespace TablicaKwadraty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[,] tablica = new int[n,n];
            int sumaPierwszaKolumna = 0;
            int sumaDrugaKolumna = 0;


            for (int i = 0; i < tablica.GetLength(0); i++)  
            {
                for (int j = 0; j < tablica.GetLength(1); j++) 
                {
                    if (j > 1)
                    {
                        tablica[i, j] = 0;
                    }
                    else if (j == 0)
                    {
                        tablica[i, j] = i;
                        sumaPierwszaKolumna += i;
                    }
                    else
                    {
                        tablica[i, j] = i * i;
                        sumaDrugaKolumna += (i * i);
                    }
                }
            }



            for (int i = 0; i < tablica.GetLength(0); i++)  //kolumny
            {
                for (int j = 0; j < tablica.GetLength(1); j++) //wiersze
                {
                    Console.Write(tablica[i,j] +" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Suma w pierwzej kolumnie jest równa {sumaPierwszaKolumna}");
            Console.WriteLine($"Suma w drugiej kolumnie jest równa {sumaDrugaKolumna}");

        }
    }
}
