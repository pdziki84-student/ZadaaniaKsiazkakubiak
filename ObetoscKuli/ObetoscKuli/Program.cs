using System;

namespace ObetoscKuli
{
    class Program
    {
        static void Main(string[] args)
        {

            double Volume = new double();
            double Radius = new double();

            Console.Write("Podaj wartość promienia kuli R: ");
            Radius = double.Parse(Console.ReadLine());

            Volume = (4 * Math.PI * Math.Pow(Radius, 3)) / 3;

            Console.WriteLine("Objętość kuli o promieniu R = {0:##.##} wynosi {1:##.##)}", Radius , Volume);
        }
    }
}


