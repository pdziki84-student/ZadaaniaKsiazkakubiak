using System;

namespace DeltaSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = new double();
            double b = new double();
            double c = new double();

            double x0 = new double();
            double x1= new double();
            double x2 = new double();

            double delta = new double();

            byte iloscPierwiastkow = 0;

            Console.Write("Podaj wartość parametru a : ");
            a = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Podałeś niepoprawną wartość parametru a");
            }
            else
            {
                Console.Write("Podaj wartość parametru b : ");
                b = double.Parse(Console.ReadLine());

                Console.Write("Podaj wartość parametru b : ");
                c = double.Parse(Console.ReadLine());
            }

            delta = (Math.Pow(b, 2)) - (4 * a * c);


            if (delta < 0) iloscPierwiastkow = 0;
            if (delta == 0) iloscPierwiastkow = 1;
            if (delta > 0) iloscPierwiastkow = 2;

            switch (iloscPierwiastkow)
            {
                case 0:
                    {
                        Console.WriteLine("Równianie nie posiada pierwiastków");
                        break;
                    }
                case 1:
                    {
                        x0 = -b / (2 * a);

                        Console.WriteLine($"Równianie posiada jeden pierwiastek x0 = {0:##.##}", x0);
                        break;
                    }
                case 2:
                    {
                        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                        Console.WriteLine("Równanie posiada dwa pierwiastki x1 = {0:##.##} x2 = {1:##.##}", x1, x2);
                        break;
                    }

                default:
                    break;
            }


        }
    }
}
