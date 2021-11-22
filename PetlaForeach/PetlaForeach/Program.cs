using System;

namespace PetlaForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //przypisywanie danych do tablicy za pomocą petli foreach
            int n  = 100;
            int[] tablica = new int[n];
            int sum = 0;

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = i + 1;
            }


            foreach (var item in tablica)
            {
                Console.WriteLine(item);
                sum += item;
            }


            Console.WriteLine($"Suma wszystkich liczb z tablicy wyynosi: {sum}");

        }
    }
}
