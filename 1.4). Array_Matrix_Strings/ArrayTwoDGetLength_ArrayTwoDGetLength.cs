// C# Program to show Row and Column Elements of 2D Array using GetLength(0) and GetLength(1)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTwoDGetLength
{
    class ArrayGetLength
    {
        static void Main(string[] args)
        {
            int[,] arr = {{ 9, 8, 7, 1 },
                { 7, 3, 0, 2 },
                { 9, 5, 3, 2 },
                { 6, 3, 1, 2 }};

            for (int i = 0; i < arr.GetLength(0); i++) // GetLength(0) - Number of Rows
            {
                for (int j = 0; j < arr.GetLength(1); j++) // GetLength(1) - Number of Columns
                {
                    Console.WriteLine(" Number[" + i + "," + j + "] :" + arr[i,j]);
                }
            }
        }
    }
}
