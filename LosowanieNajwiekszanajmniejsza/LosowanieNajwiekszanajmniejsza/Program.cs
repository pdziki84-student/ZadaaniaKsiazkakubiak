using System;

namespace LosowanieNajwiekszanajmniejsza
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5; //ilosc losowanych liczb
            int suma = 0;
            double avg = 0;
            int min = 100;
            int max = 0;


            Random random = new Random();
            int randomize = random.Next(1, 99);

           

            for (int i = 0; i < n; i++)
            {
                randomize = random.Next(1, 99);

                suma = suma + randomize;
                
                Console.WriteLine(i +" - "+randomize);


                if (randomize > max)
                {
                    max = randomize;
                }
                if(randomize < min)
                {
                    min = randomize;
                }

            }

            avg = suma / n;

            Console.WriteLine($"Średnia liczb wynosi : {avg}");
            Console.WriteLine($"maksymalna wylosowana liczba to : {max}");
            Console.WriteLine($"Minialna wylosowana liczba to : {min}");
        }
    }
}
