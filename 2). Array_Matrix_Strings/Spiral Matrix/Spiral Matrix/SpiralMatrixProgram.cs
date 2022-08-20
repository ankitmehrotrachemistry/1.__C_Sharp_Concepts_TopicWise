// Spiral Matrix of 5 x 5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral_Matrix
{
    class SpiralMatrixProgram
    {
        static void Main(string[] args)
        {
            // 1 2 3  
            // 8 9 4  
            // 7 6 5  

            //Console.Write("Enter your Number:");
            //int n = Convert.ToInt32(Console.ReadLine());

            int n = 5;

            int[,] arr = new int[n, n];

            int number = 1;

            int c1 = 0, c2 = n - 1;

            while (number <= n * n)
            {
                // Filling Values from Left to Right
                for (int i = c1; i <= c2; i++)
                    arr[c1, i] = number++;

                // Filling Values from Up to Down  
                for (int j = c1 + 1; j <= c2; j++)
                    arr[j, c2] = number++;

                // Filling Values from Right to Left
                for (int i = c2 - 1; i >= c1; i--)
                    arr[c2, i] = number++;

                // Filling Valued from Down to Up
                for (int j = c2 - 1; j >= c1 + 1; j--)
                    arr[j, c1] = number++;

                c1++;
                c2--;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
