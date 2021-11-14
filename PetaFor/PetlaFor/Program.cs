using System;

namespace PetlaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int y;
            for (int x = 0; x <= 10; x++)
            {
                y = 3 * x;
                Console.WriteLine($"Dla wartosci x = {x} \t wartość y = {y}");
            }
        }
    }
}
