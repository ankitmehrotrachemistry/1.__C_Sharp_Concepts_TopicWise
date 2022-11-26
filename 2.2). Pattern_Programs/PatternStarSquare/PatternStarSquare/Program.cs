using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternNumberTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, n;

            Console.Write("Enter the value of n");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}