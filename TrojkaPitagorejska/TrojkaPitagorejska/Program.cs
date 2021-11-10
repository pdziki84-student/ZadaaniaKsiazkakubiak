using System;

namespace TrojkaPitagorejska
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = new int();
            int b = new int();
            int c = new int();


            Console.Write("Podaj liczbę a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Podaj liczbę b: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Podaj liczbę c: ");
            c = int.Parse(Console.ReadLine());


            if ((a * a + b * b) == c * c)
            {
                Console.WriteLine("\nLiczby: ");
                Console.Write($"a = {a} \nb = {b} \nc ={c}\n");
                Console.WriteLine("\nsą trójką pitagorejską");
            }
            else
            {
                Console.WriteLine("\nLiczby: ");
                Console.Write($"a = {a} \nb = {b} \nc = {c}\n");
                Console.WriteLine("\nnie są trójką pitagorejską");
            }



            Console.ReadKey();

        }
    }
}
