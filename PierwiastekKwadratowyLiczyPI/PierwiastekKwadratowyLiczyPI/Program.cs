using System;

namespace PierwiastekKwadratowyLiczyPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pierwiastek kwadratowy PI");
            Console.WriteLine("{0:#.##}", Math.Sqrt(Math.PI));

            Console.ReadKey();
        }
    }
}
