using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacjeNaPlikach_2
{
    class MatrixZmianaWierszNaKolumne
    {
        private FileStream file_out;
        private FileStream file_in;

        public void wczytaj_dane(int[,] a, int n)
        {
            Console.WriteLine("Za chwle dane zostaną wczytane...");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == 1)
                    {
                        a[i, j] = 1;
                    }
                    else
                    {
                        a[i, j] = 0;
                    }
                }
            }
            Console.WriteLine();
        }

        public void przetworz_dane(int[,] a, int[,] b, int n)
        {       
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    b[i, j] = a[j,i];
                    Console.Write(b[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void zapisz_dane_do_pliku(int[,] b, int n)
        {
            file_out = new FileStream("dane.txt", FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(file_out);

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    streamWriter.Write((char) b[i, j]);
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            streamWriter.Close();
            file_out.Close();
        }


        public void wczytaj_dane_z_pliku(int[,] c, int n)
        {
            Console.WriteLine();
            file_in = new FileStream("dane.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(file_in);

            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    c[i, j] = (int)streamReader.Read();
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
            streamReader.Close();
            file_in.Close();
            Console.WriteLine();
        }
    }
}



