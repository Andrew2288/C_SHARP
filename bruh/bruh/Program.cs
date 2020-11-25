using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruh
{
    class Program
    {
        static void Main(string[] args)
        {
            int stroka, stolb;
            stroka = int.Parse(Console.ReadLine());
            stolb = int.Parse(Console.ReadLine());
            int[,] mas = new int[stroka, stolb];
            for (int i = 0; i < mas.GetLength(0); ++i)
            {
                for (int j = 0; j < mas.GetLength(1); ++j)
                {
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            try 
            {
                Console.WriteLine(2 / mas[0, 0]);
            }
            catch
            {
                Console.WriteLine("Lox");
            }
            finally
            {
                Console.WriteLine("Krasavec");
            }
            for (int i = 0; i < mas.GetLength(0); ++i)
            {
                for (int j = 0; j < mas.GetLength(1); ++j)
                {
                    Console.Write(Convert.ToString(mas[i, j]) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
