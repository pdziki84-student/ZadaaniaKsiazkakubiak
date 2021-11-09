using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoleProstokata
{
    class Prostokat
    {
        private double A  { get; set; }
        private double B { get; set; }
        private double Pole { get; set; }

        public Prostokat(double _a, double _b)
        {
            A = _a;
            B = _b;

            Pole = PoleProstokata();
        }

        public Prostokat()
        {
            Console.Write("Podaj wartość pierwszego boku: ");
            A = double.Parse(Console.ReadLine());

            Console.Write("Podaj wartość drugiego boku: ");
            B = double.Parse(Console.ReadLine());

            Pole = PoleProstokata();
        }

        private double PoleProstokata()
        {
            return Pole = A * B;
        }


        public void WypiszDane()
        {
            Console.WriteLine("a = " + A);
            Console.WriteLine($"b = {B}");
            Console.WriteLine($"pole = {Pole}");

            Console.WriteLine($"Pole prostokata o wymiarach {A} x {B} wynosi {Pole}");

        }
    }
}
