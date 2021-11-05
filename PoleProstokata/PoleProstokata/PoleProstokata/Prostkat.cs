using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoleProstokata
{
    class Prostkat
    {
        private double a = new double();
        private double b = new double();
        private double pole = new double();

        public Prostkat(double _a, double _b)
        {
            a = _a;
            b = _b;
        }

        public Prostkat()
        {
            Console.Write("Podaj wartość pierwszego boku: ");
            this.a = double.Parse(Console.ReadLine());

            Console.Write("Podaj wartość drugiego boku: ");
            this.b = double.Parse(Console.ReadLine());

            this.pole = this.a * this.b;
        }

        //private double Pole(double pole)
        //{
        //    return this.pole = a * b;
        //}

        public void PoleProstokata()
        {
            Console.WriteLine("pole = ", pole);
        }
    }
}
