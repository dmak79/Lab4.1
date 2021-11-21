using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, e = 1;
            Console.Write("Введите число N=");
            int n = int.Parse(Console.ReadLine());
            while (e <= n * 2)
            {
                sum = sum + e;
                Console.WriteLine(sum);
                e = e + 2;
            }
            Console.ReadKey();
        }
    }
}
