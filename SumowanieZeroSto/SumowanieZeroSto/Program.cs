using System;

namespace SumowanieZeroSto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For");
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("Suma liczb od 1 do 100 to: " + suma);

            Console.WriteLine("\n\nDo While");
            
            int suma1 = 0, id = 1;

            do
            {
                suma1 = suma1 + id;
                id++;
            } while (id < 101);
            Console.WriteLine("Suma liczb to : " + suma1);

            Console.WriteLine("\n\nWhile");
            int suma2 = 0, j = 1;

            while (j <= 100)
            {
                suma2 = suma2 + j;
                j++;
            }
            Console.WriteLine("Suma to: " + suma2);
        }
    }
}
