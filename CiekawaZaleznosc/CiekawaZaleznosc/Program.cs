using System;

namespace CiekawaZaleznosc
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilosc_punktow = 100000;
            int licznik = 0;
            double x;
            double y;
            double pi;


            Random r = new Random();

            for (int i = 1; i < ilosc_punktow; i++)
            {
                x = Math.Round(100 * (r.NextDouble())) / 100.0;
                y = Math.Round(100 * (r.NextDouble())) / 100.0;

                if (x * x + y * y <= 1) 
                {
                    licznik = licznik + 1;
                }

                pi = 4.0 * licznik / ilosc_punktow;

                Console.WriteLine("Wartość pi = " + Math.PI);
                Console.WriteLine("Obliczona wartość PI = " + pi);

                //Console.ReadKey();
            }

        }
    }
}
