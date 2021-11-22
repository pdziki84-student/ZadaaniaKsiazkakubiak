using System;
using System.Collections;

namespace ArayLista
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();

            lista.Add(20);
            lista.Add(51);
            lista.Add(0);
            lista.Add(-30);
            lista.Add(3);
            lista.Add(9);

            Console.WriteLine("\n\nlista przed sortowaniem\n\n");

            foreach (var item in lista)
            {
                Console.Write(item +" ");
            }

            lista.Sort();


            Console.WriteLine("\n\nlista po sortowaniu\n\n");

            foreach (var item in lista)
            {
                Console.Write(item + " ");
            }

            lista.RemoveAt(1);

            Console.WriteLine("\n\nlista po usunięciu drugiego elementu\n\n");

            foreach (var item in lista)
            {
                Console.Write(item + " ");
            }


            lista.Add(-3);

            Console.WriteLine("\n\nlista po dodaniu elementu\n\n");

            foreach (var item in lista)
            {
                Console.Write(item + " ");
            }

            lista.Sort();


            Console.WriteLine("\n\nlista po ponownym sortowaniu\n\n");

            foreach (var item in lista)
            {
                Console.Write(item + " ");
            }


            Console.WriteLine("\n\n\narray imiona\n\n\n");

            ArrayList imiona = new ArrayList();

            imiona.Add("Marek");
            imiona.Add("Kamil");
            imiona.Add("Ambroży");
            imiona.Add("Zenon");
            imiona.Add("Rafał");
            imiona.Add("Kasia");

            Console.WriteLine("\nElementy nieposortowane\n");
            Display(imiona);

            imiona.Sort();
            Console.WriteLine("\nElementy posrtowane\n");
            Display(imiona);

            imiona.RemoveAt(1);
            Console.WriteLine("\nwywalony drugi element listy\n");
            Display(imiona);

            imiona.Add("Bożydar");
            Console.WriteLine("\ndodano jeden element\n");
            Display(imiona);

            imiona.Sort();
            Console.WriteLine("\nsortowanie pod dodaniu nowego elementu\n");
            Display(imiona);

        }

        static void Display(ArrayList imiona)
        {
            foreach (var item in imiona)
            {
                Console.WriteLine(item);
            }
        }
    }
}
