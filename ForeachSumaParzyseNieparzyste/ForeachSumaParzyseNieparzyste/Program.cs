using System;

namespace ForeachSumaParzyseNieparzyste
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int[] dane = new int[n];
            int sumaParzyste = 0;
            int sumaNieparzyste = 0;

            for (int i = 0; i < dane.Length; i++)
            {
                dane[i] = i + 1;
            }


            foreach (var dana in dane)
            {
                if (dana % 2 == 0)
                {
                    sumaParzyste += dana;
                }
                else
                {
                    sumaNieparzyste += dana;
                }
            }

            Console.WriteLine($"Suma liczb parzystcyhc wynosi: {sumaParzyste}\nSuma liczb nieparzystych wynosi: {sumaNieparzyste}");
        }
    }
}
