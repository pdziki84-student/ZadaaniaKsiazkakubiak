using System;

namespace GraZgadywanieLiczby
{
    class Program
    {
        static void Main(string[] args)
        {
            int dolnyZakres = 1;
            int gornyZakres = 100;

            Random losuj = new Random();
            int wylosowana = losuj.Next(dolnyZakres, gornyZakres);
            bool spr = true;


            int liczbaUzytkownika = 0;

            Console.WriteLine(wylosowana);

            while (spr)
            {
                Console.Write("Zgadnik jaką liczbę wylosowano z zakresu {0} {1}\nTwój wybór: ", dolnyZakres, gornyZakres );
                liczbaUzytkownika = int.Parse(Console.ReadLine());

                if (wylosowana > liczbaUzytkownika)
                {
                    Console.WriteLine("Twoja liczba jest za mała");
                }
                else if (wylosowana < liczbaUzytkownika)
                {
                    Console.WriteLine("Twoja liczba jest za duza");
                }
                else
                {
                    Console.WriteLine("Gratulacje wygrałeś");
                    spr = false;
                }
            }
        }
    }
}
