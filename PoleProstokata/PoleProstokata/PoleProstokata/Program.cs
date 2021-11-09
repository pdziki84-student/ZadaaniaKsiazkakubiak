using System;

namespace PoleProstokata
{
    class Program
    {
        static void Main(string[] args)
        {
            //double a = new double();
            //double b = new double();
            //double pole = new double();

            //Console.Write("Podaj wartość pierwszego boku: ");
            //a = double.Parse(Console.ReadLine());

            //Console.Write("Podaj wartość drugiego boku: ");
            //b = double.Parse(Console.ReadLine());

            //Console.WriteLine($"Pole powierzchni prostkąta o bokach {a} x {b} wynosi: {pole = a * b}");

            Prostkat prostkat = new Prostkat(2,3);

            prostkat.WypiszDane();
            
            
        }
    }
}
