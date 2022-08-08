using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloydTriangle
{
    /*
        1 
        2 3 
        4 5 6 
        7 8 9 10 
        11 12 13 14 15
    */
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k = 1;

            Console.WriteLine("Enter the value of N");
            int N = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= N; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(k);
                    k++;
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
