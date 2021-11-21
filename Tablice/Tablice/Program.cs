using System;

namespace Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dane = new int[10];
            int[] dane1 = new int[10];


            for (int i = 0; i < dane.Length; i++)
            {
                dane[i] = i;
            }

            for (int i = 0; i <dane.Length; i++)
            {
                Console.WriteLine($"Dane[{i}] = {dane[i]}");
            }


            Console.WriteLine("\n\na teraz odwrotnie \n\n\n");

            for (int i = 0, j = 9; i < dane1.Length; i++, j--)
            {
                dane1[i] = j;
            }

            for (int i = 0; i < dane1.Length; i++)
            {
                Console.WriteLine($"Dane[{i}] = {dane1[i]}");
            }
        }
    }
}
