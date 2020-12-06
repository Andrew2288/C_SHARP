using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruh
{
    class Program
    {
        static void split(ref int[] mas, in string stroka, out int k)
        {
            string chislo = "";
            int i = 0;
            k = 0;
            while (i < stroka.Length)
            {
                if (stroka[i] != ' ')
                {
                    chislo += stroka[i];
                }
                if (((stroka[i] == ' ') || (i == (stroka.Length - 1))) && (chislo != ""))
                {
                    mas[k] = int.Parse(chislo);
                    k += 1;
                    chislo = "";
                }
                i += 1;
            }
        }

        static void Main(string[] args)
        {
            int[] mas = new int[100000000];
            string stroka = Console.ReadLine();
            int k;
            split(ref mas, stroka, out k);
            for (int i = 0; i < k; i++)
            {
                Console.Write(Convert.ToString(mas[i]) + " ");
            }
        }
    }
}
