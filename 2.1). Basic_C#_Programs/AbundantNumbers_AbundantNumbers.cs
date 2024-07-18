using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbundantNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to find it's abundance");
            int M = Convert.ToInt32(Console.ReadLine());

            int n, sum = 0;
            n = M;

            for (int i = 1; i < n; i++)
            {
                if (M % i == 0)
                {
                    sum = sum + i;
                }
                else
                {
                    continue;
                }
            }

            if (sum > M)
            {
                Console.WriteLine("The Given Number is {0} an Abundant Number ={1}", M, sum);
            }
            else
            {
                Console.WriteLine("Not an Abundant Number");
            }
            Console.WriteLine("\n");
        }
    }
}
