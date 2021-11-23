using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObliczanieRownaniaKwadratowego
{
    class Trojmian
    {
        private double a = new double();
        private double b = new double();
        private double c = new double();
        private double x0 = new double();
        private double x1 = new double();
        private double x2 = new double();
        private double delta = new double();
        private byte iloscPierwiastkow = new byte();




        public void WczytajDane()
        {
            Console.Write("Podaj wartość zmiennej a = ");
            a = double.Parse(Console.ReadLine());
            SprawdzA();
            Console.Write("Podaj wartość zmiennej b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Podaj wartość zmiennej c = ");
            c = double.Parse(Console.ReadLine());
        }

        public void PrzetworzDane()
        {
            delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta == 0)
            {
                iloscPierwiastkow = 1;

                x0 = (-b) / (2 * a);
            }
            else if (delta > 0)
            {
                iloscPierwiastkow = 2;

                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);

            }
            else
            {
                iloscPierwiastkow = 0;
            }

        }

        public void WyswietlDane()
        {
            switch (iloscPierwiastkow)
            {
                case 0:
                    {
                        Console.WriteLine("Równanie nie posiada pierwiastków!!");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Równanie posiada jedno rozwiązanie");
                        Console.WriteLine("x0 = {0:##.##}",x0);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Równanie posiada dwa rozwiązania");
                        Console.WriteLine("x1 = {0:##.##}\nx2 = {1:##.##}",x1,x2);
                        break;
                    }
                default:
                    break;
            }

        }

        private void SprawdzA()
        {
            if (a == 0)
            {
                Console.WriteLine("Wprowadzono niedozwolony współczynnik A\nWciśnij enter");
                Console.Read();
                Environment.Exit(0);

            }
        }
    }
}
