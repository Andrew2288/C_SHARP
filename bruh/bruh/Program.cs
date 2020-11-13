using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruh
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka;
            int sum = 0;
            stroka = Console.ReadLine();
            try
            {
                int a = int.Parse(stroka);
                while (a != 0)
                {
                    sum += a % 10;
                    a /= 10;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Lox");
            }
            Console.WriteLine(sum);
        }
    }
}
