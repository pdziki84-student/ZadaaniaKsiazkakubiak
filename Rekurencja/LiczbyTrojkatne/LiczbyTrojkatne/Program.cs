using System;

namespace LiczbyTrojkatne
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Triangle liczby = new Triangle();
            Console.Write("podaj liczbę : ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("program znajduje n pierwszych liczba trójkątnych");
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("#" + i + " = " + liczby.triangle(i));
            }
        }
    }
}
