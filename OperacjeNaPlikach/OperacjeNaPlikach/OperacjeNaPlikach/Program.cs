using System;
using System.IO;

namespace OperacjeNaPlikach
{
    class Program
    {
        static void Main(string[] args)
        {

            //string NazwaPliku = "InputOtputFile.txt";
            //string imie;
            //string nazwisko;

            //FileStream fileStrem = new FileStream(NazwaPliku, FileMode.OpenOrCreate);
            //StreamWriter streamWriter = new StreamWriter(fileStrem);
            PlikTekstowy plikTekstowy = new PlikTekstowy();

            plikTekstowy.czytaj_dane();
            plikTekstowy.zapisz_dane_do_pliku();
            plikTekstowy.czytaj_dane_z_pliku();

        }
    }
}
