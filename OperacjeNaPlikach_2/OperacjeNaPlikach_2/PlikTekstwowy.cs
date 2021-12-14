using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacjeNaPlikach_2
{
    class PlikTekstwowy
    {
        //const int n = 10;
        //private int[,] dane = new int[n,n];

        //private string dane1;

        private FileStream file_out;
        private FileStream file_in;

        public void wczytaj_dane(int[,] dane, int n)
        {
            Console.WriteLine("Za chwle dane zostaną wczytane...");
            for (int i = 0; i < dane.GetLength(0); i++)
            {
                for (int j = 0; j < dane.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        dane[i, j] = 1;
                    }
                    else
                    {
                        dane[i, j] = 0;
                    }
                }
            }
            Console.WriteLine();
        }
        public void zapisz_dane_do_pliku(int[,] dane, int n)
        {
            file_out = new FileStream("dane.txt", FileMode.OpenOrCreate);
            StreamWriter streamWriter = new StreamWriter(file_out);

            for (int i = 0; i < dane.GetLength(0); i++)
            {
                for (int j = 0; j < dane.GetLength(1); j++)
                {
                    streamWriter.Write((char)dane[i, j]);
                    Console.Write(dane[i,j] + " ");
                }
                Console.WriteLine();
            }
            streamWriter.Close();
            file_out.Close();
        }


        public void wczytaj_dane_z_pliku(int[,] dane1, int n)
        {
            Console.WriteLine();
            file_in = new FileStream("dane.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(file_in);

            for (int i = 0; i < dane1.GetLength(0); i++)
            {
                for (int j = 0; j < dane1.GetLength(1); j++)
                {
                    dane1[i, j] = (int)streamReader.Read();
                    Console.Write(dane1[i,j] + " ");
                }
                Console.WriteLine();
            }
            streamReader.Close();
            file_in.Close();
            Console.WriteLine();
        }
    }
}