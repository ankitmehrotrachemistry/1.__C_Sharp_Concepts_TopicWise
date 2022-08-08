using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternNumberLadder
{
    class Program
    {
        /* 
         1        1
         12      21
         123    321
         1234  4321
         1234554321
         */
        static void Main(string[] args)
        {
            int n, i, j, k;
            Console.Write("Enter the value of n");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    if (j <= i)
                        Console.Write(j);
                    else
                        Console.Write(" ");
                }
                for (j = n; j >= 1; j--)
                {
                    if (j <= i)
                        Console.Write(j);
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
        }
    }
}
