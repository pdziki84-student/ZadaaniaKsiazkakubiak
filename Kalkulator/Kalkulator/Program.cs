using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = new double();
            double y = new double();
            double suma = new double();
            double roznica = new double();
            double iloraz = new double();
            double iloczyn = new double();


            Console.Write("Podaj wartosc pierszej liczby: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Podaj wartosc drugiej liczby: ");
            y = double.Parse(Console.ReadLine());

            suma = x + y;
            roznica = x - y;
            iloczyn = x * y;
            iloraz = x / y;


            Console.WriteLine("Suma dwóch liczb równa się {0:##.##}", suma);
            Console.WriteLine("Różnica dwoch liczb wynosi {0:##.##}", roznica);
            Console.WriteLine("Iloczyn dwóch liczb wynosi {0:###.##}", iloczyn);
            Console.WriteLine("Iloraz dwóch liczb wynosi {0:##.##}", iloraz);

        }
    }
}
