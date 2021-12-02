using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TworzenieOsoby
{
    class Kadra : Osoba
    {
        string wyksztalcenie;
        string stanowisko;

        public void Wczytaj1()
        {
            wczytaj();
            Console.Write("Podaj wykształcenie: ");
            wyksztalcenie = Console.ReadLine();
            Console.Write("Podaj stanowisko: ");
            stanowisko = Console.ReadLine();
        }

        public void Wyswietl1()
        {
            wyswietl();
            Console.WriteLine($"Wykształcenie : {wyksztalcenie}");
            Console.WriteLine($"Stanowisko : {stanowisko}");
        }
    }
}
