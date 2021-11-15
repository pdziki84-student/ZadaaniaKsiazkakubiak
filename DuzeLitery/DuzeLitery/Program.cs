using System;

namespace DuzeLitery
{
    class Program
    {
        static void Main(string[] args)
        {
            char znak, znak1;
            int i = 0;
            char[] tablica = new char[25];


            for (znak = 'A'; znak <= 'Z'; znak++)
            {
                Console.Write(znak + "\t");
                
                if (i%8 == 0)
                {
                    Console.WriteLine();
                }
                i++;
            }
            
            Console.WriteLine("\n\n\n");
            for (znak1 = 'Z'; znak1 >= 'A'; znak1--)
            {
                Console.Write(znak1 + "\t");
                if (i % 8 == 0)
                {
                    Console.WriteLine();
                }
                i++;

            }

        }
    }
}
