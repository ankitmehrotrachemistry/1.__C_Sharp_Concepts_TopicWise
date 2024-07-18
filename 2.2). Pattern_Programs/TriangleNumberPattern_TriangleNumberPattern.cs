using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleNumberPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Enter the value of n");

            n = int.Parse(Console.ReadLine());

            for (int a = 1; a <= n; a++)
            {
                for (int b = 1; b <= n - a; b++)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= a; c++)
                {
                    Console.Write(c);
                }
                for (int d = a - 1; d >= 1; d--)
                {
                    Console.Write(d);
                }
                Console.Write("\n");
            }
        }
    }
}
