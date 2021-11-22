using System;

namespace DweTabliceKopiowaieTaansformacja
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[,] macierzA = new int[n, n];
            int[,] macierzB = new int[n, n];

            for (int i = 0; i < macierzA.GetLength(0); i++)
            {
                for (int j = 0; j < macierzA.GetLength(1); j++)
                {
                    macierzA[i, j] = j;
                }
            }

            for (int i = 0; i < macierzA.GetLength(0); i++)
            {
                for (int j = 0; j < macierzA.GetLength(1); j++)
                {
                    macierzB[i, j] = macierzA[j,i];
                }
            }




            for (int i = 0; i < macierzA.GetLength(0); i++)
            {
                for (int j = 0; j < macierzA.GetLength(1); j++)
                {
                    Console.Write(macierzA[i, j] +" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n\n\n");

            for (int i = 0; i < macierzB.GetLength(0); i++)
            {
                for (int j = 0; j < macierzB.GetLength(1); j++)
                {
                    Console.Write(macierzB[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
