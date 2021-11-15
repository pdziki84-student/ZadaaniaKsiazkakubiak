using System;

namespace DzielenieModulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int dgp = 1000; //dolnaGranicaPrzedzialu
            int ggp = 9999; //gornaGranicaprzedzialu
            int ilosc = 0;

            int pdc; // pierwszeDwieCyfry
            int kdc; // koljneDwieCyfry


            for (int i = dgp; i < ggp; i++)
            {
                pdc = i / 100;
                kdc = i % 100;

                if (pdc * pdc + kdc*kdc == i)
                {
                    Console.WriteLine($"Liczba {i} spełnia ciekawą zależność");
                    ilosc++;
                }
            }
            Console.WriteLine($"Wszystkich ciekawych zależności jest {ilosc}");
        }
    }
}
