using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;

            while (x <= 10)
            {
                y = 3 * x;
                Console.WriteLine($"X = {x}\t y= {y}");

                x++;
            }
        }
    }
}
