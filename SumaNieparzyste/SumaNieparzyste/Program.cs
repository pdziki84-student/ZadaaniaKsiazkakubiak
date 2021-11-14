using System;

namespace SumaParzyste
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (!(i % 2 == 0))
                {
                    suma = suma + i;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("For suma = " + suma);

            int suma1 = 0, j = 0;
            Console.WriteLine("\n\nDo While");

            do
            {
                if (j % 2 != 0)
                {
                    suma1 = suma1 + j;
                }
                j++;
            } while (j < 101);
            Console.WriteLine("DoWhile = " + suma1);
            Console.WriteLine("\n\nWhile");

            int suma2 = 0, k = 0;

            while (k <= 100)
            {
                if (k % 2 != 0)
                {
                    suma2 = suma2 + k;
                }
                k++;
            }
            Console.WriteLine("while = " + suma2);
        }
    }
}
