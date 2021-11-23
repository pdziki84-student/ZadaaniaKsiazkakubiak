using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortowanieBabelkowe
{
    class Sortowanie
    {
        int k;

        public void WczytajDane(int[] tablica)
        {
            Random rand = new Random();
            int randomize;

            for (int i = 0; i < tablica.Length; i++)
            {
                randomize = rand.Next(-8000, 9999);

                tablica[i] = randomize;
            }
        }

        public void PrzetworzDane(int[] tab)
        {
            Array.Sort(tab);

            //sortowanie babelkowe

            //for (int i = 1; i < tab.Length; i++)
            //{
            //    for (int j = tab.Length; j >= i; j--)
            //    {
            //        if (tab[j-1] > tab[j])
            //        {
            //            k = tab[j - 1];
            //            tab[j - 1] = tab[j];
            //            tab[j] = k;
            //        }
            //    }
            //}

        }

        public void WyswietlDane(int[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {

                Console.Write(tablica[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
