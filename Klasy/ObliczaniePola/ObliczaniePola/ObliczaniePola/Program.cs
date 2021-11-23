using System;

namespace ObliczaniePola
{
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat pierwszy = new Prostokat();
            pierwszy.WczytajDane();
            pierwszy.PrzetworzDane();
            pierwszy.WyswietlDane();
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