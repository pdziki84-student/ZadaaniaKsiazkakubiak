using System;

namespace TabliczkaMnozenia
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    Console.Write(row * col +"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
