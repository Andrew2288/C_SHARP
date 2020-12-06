using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_merni_massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[][][] mas = new int[rand.Next(2, 6)][][];
            for (int i = 0; i < mas.Length; ++i)
            {
                Console.WriteLine("Page" + (i + 1));
                mas[i] = new int[rand.Next(2, 6)][];
                for (int j = 0; j < mas[i].Length; ++j)
                {
                    mas[i][j] = new int[rand.Next(2, 6)];
                    for (int z = 0; z < mas[i][j].Length; ++z)
                    {
                        mas[i][j][z] = rand.Next(2, 6);
                        Console.Write(mas[i][j][z] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n=================");
            }
        }
    }
}
