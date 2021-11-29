using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TworzenieOsoby
{
    class Osoba
    {
        string Nazwisko;
        string Imie;
        string ulica;
        string kod;
        string miasto;

        public void wczytaj()
        {
            Console.Write("Podaj nazwisko: ");
            Nazwisko = Console.ReadLine();
            Console.Write("Podaj imię: ");
            Imie = Console.ReadLine();
            Console.Write("Podaj ulice: ");
            ulica = Console.ReadLine();
            Console.Write("Podaj kod: ");
            kod = Console.ReadLine();
            Console.Write("Podaj miasto: ");
            miasto = Console.ReadLine();
        }


        public void wyswietl()
        {
            Console.WriteLine($"Imię: {Imie} Nazwisko : {Nazwisko}");
            Console.WriteLine($"Ulica: {ulica}");
            Console.WriteLine($"kod: {kod} miasto: {miasto}");
        }

    }
}
