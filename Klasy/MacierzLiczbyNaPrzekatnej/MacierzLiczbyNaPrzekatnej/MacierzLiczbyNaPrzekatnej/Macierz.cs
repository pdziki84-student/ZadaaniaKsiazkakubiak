using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacierzLiczbyNaPrzekatnej
{
    class Macierz
    {
        private double suma = new double();
        Random rand = new Random();
        int randomize;

        public void WczytajDane(double[,] tab)
        {

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        randomize = rand.Next(0, 9);

                        tab[i, j] = randomize;
                    }
                    else
                    {
                        tab[i, j] = 0;
                    }
                }
            }
        }


        public void PrzetworzDane(double[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        suma += tab[i, j];
                    }
                }
                
            }
        }

        public void WyswietlDane(double[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write(tab[i, j] +" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Suma liczb na przekatnej wynosi: {suma}");
        }
    }

}
