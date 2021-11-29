using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int zakres;
            Console.Write("Podaj zakres do jakiej liczby obliczać : ");
            zakres = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < zakres; i++)
            {
                Console.WriteLine(Fibo(i));
            }

        }

        public static int Fibo(int zak)
        {

            if (zak == 0)
            {
                return 0;
            }

            else if (zak == 1)
            {
                return 1;
            }
            else
            {
                return Fibo(zak - 1) + Fibo(zak - 2);
            }
 
        }
    }
}
