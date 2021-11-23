using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObliczaniePola
{
    class Prostokat
    {
        private double BokA = new double();
        private double BokB = new double();
        private double Pole = new double();


        public void WczytajDane()
        {
            Console.Write("Podaj wartość boku A= ");
            BokA = double.Parse(Console.ReadLine());
            Console.Write("Podaj wartość boku B= ");
            BokB = double.Parse(Console.ReadLine());
        }

        public void PrzetworzDane()
        {
            Pole = BokA * BokB;
        }

        public void WyswietlDane()
        {
            Console.WriteLine("Bok A = {0:##.##}\nBok B = {1:##.##}", BokA, BokB);
            Console.WriteLine("Pole prostokata o boku {0:##.##} x {1:##.##} wynosi {2:##.##} ", BokA, BokB,Pole);
        }
    }
}

/*
 program powinien zawierać 3 metody
- wczytaj_dane
    -dane typu double: a,b,pole
-przetworz_dane
    - pole = a*b
-wyswietl_dane
    -wyswietla wartosci a i b oraz pole
 */