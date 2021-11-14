using System;

namespace ForWyswietlanieLiczb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For");

            for (int i = 1; i < 21; i++)
            {
                Console.Write($"{i}. ");
            }

            Console.WriteLine("\n\nDo while");
            int x = 1;
            do
            {
                Console.Write(x +". ");
                x++;
            } while (x<21);

            Console.WriteLine("\n\nWhile");
            int y = 1;

            while (y <= 20)
            {
                Console.Write(y +". ");
                y++;
            }
            Console.WriteLine();
        }
    }
}
