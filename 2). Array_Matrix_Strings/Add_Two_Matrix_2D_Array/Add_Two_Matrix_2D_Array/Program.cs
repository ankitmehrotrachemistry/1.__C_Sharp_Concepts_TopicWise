using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Two_Matrix_2D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 3;
            int[,] arr1 = new int[10, 10];
            int[,] arr2 = new int[10, 10];
            int[,] arr3 = new int[10, 10];

            Console.WriteLine("Enter First Array Elements");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter Second Array Elements");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n First Matrix is : \n");
            for (int i = 0; i < N; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0}\t", arr1[i, j]);
                }
            }

            Console.WriteLine("\n Second Matrix is : \n");
            for (int i = 0; i < N; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0}\t", arr2[i, j]);
                }
            }

            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    arr3[i, j] = arr1[i, j] + arr2[i,j];

            Console.WriteLine("\n Addition of Matrix");

            for (int i = 0; i < N; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0}\t", arr3[i,j]);
                }
            }
        }
    }
}
