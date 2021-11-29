using System;

namespace Silnia
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Podaj liczbę n: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine(Silnia(n));
           
        }

        public static long Silnia(int n)
        {
            long zwrot = 1;

            if (n >= 2)
            {
                zwrot = n * Silnia(n - 1);
            }

            return zwrot;
        }
    }
}