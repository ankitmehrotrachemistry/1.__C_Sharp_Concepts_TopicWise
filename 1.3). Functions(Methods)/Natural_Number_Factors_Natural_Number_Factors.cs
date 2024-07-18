using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natural_Number_Factors
{
    class Program
    {
        static void printDivisors(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("The Divisors are : ");
            printDivisors(100);
        }
    }
}
