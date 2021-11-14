using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y;

            do
            {
                y = 3 * x;
                Console.WriteLine($"Dla x= {x}\t y= {y}");
                x++;
            } while (x <= 10);
        }
    }
}
