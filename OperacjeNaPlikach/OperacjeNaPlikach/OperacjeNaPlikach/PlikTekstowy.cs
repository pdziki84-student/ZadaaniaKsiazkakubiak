using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacjeNaPlikach
{
    class PlikTekstowy
    {
        private string dane;
        private string dane1;

        private FileStream file_out;
        private FileStream file_in;
        public void czytaj_dane()
        {
            Console.WriteLine("Wpisujemy dane do pliku tekstowego");
            Console.Write("Podaj swoje imię i nazwisko: ");
            dane = Console.ReadLine();
        }
        public void zapisz_dane_do_pliku()
        {
            file_out = new FileStream("dane.txt", FileMode.OpenOrCreate);
            //strumien znakow polaczony z plikiem
            StreamWriter streamWriter = new StreamWriter(file_out);

            streamWriter.Write(dane); //zapisywanie łańcucha d pliku
            streamWriter.Close(); //zamykanie zapisu
            file_out.Close(); //zamykanie pliku
        }
        public void czytaj_dane_z_pliku()
        {
            Console.WriteLine();
            Console.WriteLine("Odczyt danych z pliku");

            file_in = new FileStream("dane.txt", FileMode.Open);
            //tworzenie strumienia znaków połączonego z plikiem w trybie open
            StreamReader streamReader = new StreamReader(file_in);
            //tworzeni strumienia wejsciowego
            while ((dane1 = streamReader.ReadLine()) != null)
            //odczytywanie danych az do konca pliku
            {
                Console.WriteLine(dane1);
            }
            streamReader.Close();//zamykanie odczytu
            file_in.Close();//zamykanie pliku
        }
    }
}
