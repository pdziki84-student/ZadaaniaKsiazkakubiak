using System;

namespace ResztaZDzielenia
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = new int();
            int b = new int();


            a = 37;
            b = 11;

            Console.WriteLine($"Reszta z dzielenia dwóch liczb {a} i {b} \na % b = " + a%b);
        }
    }
}
