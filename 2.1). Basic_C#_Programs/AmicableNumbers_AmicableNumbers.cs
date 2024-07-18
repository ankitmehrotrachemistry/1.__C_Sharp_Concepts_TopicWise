using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmicableNumbers
{
    // 220 and 284 are examples of amicable numbers. The factors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55, and 110,
    // which sum to 284, while the factors of 284 are 1, 2, 4, 71, and 142, which sum to 220.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int N = Convert.ToInt32(Console.ReadLine());

            int sum1 = 0, sum2 = 0;
            int i = 0, j = 0;

            for (i = 1; i < N; i++)
            {
                if (N % i == 0)
                {
                    sum1 = sum1 + i;
                }
            }
            for (j = 1; j < sum1; j++)
            {
                if (sum1 % j == 0)
                {
                    sum2 = sum2 + j;
                }
            }

            if (N == sum2)
            {
                Console.WriteLine("The given numbers {0}  and {1} are amicable numbers ", N, sum1);
            }
        }
    }
}
