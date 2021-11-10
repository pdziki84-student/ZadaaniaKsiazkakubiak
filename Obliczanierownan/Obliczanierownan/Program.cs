using System;

namespace Obliczanierownan
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = new double();
            double b = new double();
            double c = new double();
            double x = new double();


            Console.Write("Podaj wartość parametru a: ");
            a = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Wprowadzono niewłaściwą wartość parametru a!!!");
            }
            else
            {
                Console.Write("Podaj wartość parametru a: ");
                b = double.Parse(Console.ReadLine());

                Console.Write("Podaj wartość parametru a: ");
                c = double.Parse(Console.ReadLine());
            }

            x = (c - b) / a;

            Console.WriteLine("Dla: \na= {0:##.##}\nb= {1:##.##}\nc= {2:##.##}", a, b, c);
            Console.WriteLine($"Wynik równania {a}x + {b} = {c} ");
            Console.WriteLine("wynosi x = {0:##.##}", x);

        }
    }
}



