using System;

namespace Delta
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = new double();
            double b = new double();
            double c = new double();

            double x0 = new double();
            double x1 = new double();
            double x2 = new double();

            double delta = new double();



            Console.Write("Podaj wartość parametru a : ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Podaj wartość parametru b : ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Podaj wartość parametru b : ");
            c = double.Parse(Console.ReadLine());

            delta = (Math.Pow(b, 2)) - (4 * a * c);

            if (delta < 0)
            {
                Console.WriteLine(delta);
                Console.WriteLine("Równianie nie posiada pierwiastków");
            }
            else if (delta == 0)
            {
                x0 = -b / (2 * a);
                Console.WriteLine(delta);
                Console.WriteLine($"Równianie posiada jeden pierwiastek x0 = {x0}");
            }
            else
            {
                Console.WriteLine(delta);
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);


                Console.WriteLine("Równanie posiada dwa pierwiastki x1 = {0} x2 = {1}", x1, x2);
            }

            Console.ReadKey();
        }
    }
}



//delta
/*
 ax^2 + bx + c = 0

delta = b^2 -4 *a*c

x1 = (-b + sqrt delta)/2*a
x2 = (-b - sqrt delta)/2*a
 
x0 = -b / 2*a

delta < 0 -> brak pierwiatsków
 */