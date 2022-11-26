using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternNumberDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, k;
            Console.Write("Enter the value of n : ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                for (j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k < (i * 2); k++)
                {
                    Console.Write(k);
                }
                Console.Write("\n");
            }
            for (i = n; i >= 1; i--)
            {
                for (j = n; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k < (i * 2); k++)
                {
                    Console.Write(k);
                }
                Console.Write("\n");
            }
        }
    }
}