using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_ZigZag
{
    class Program
    {
        static void PrintMatrixZigZag(int row, int col, int[,] array)
        {
            int evenRow = 0;
            int oddRow = 1;

            while (evenRow < row)
            {
                for (int i = 0; i < col; i++)
                {
                    Console.Write(array[evenRow, i] + " ");
                }

                evenRow = evenRow + 2;

                if (oddRow < row)
                {
                    for (int i = col - 1; i >= 0; i--)
                    {
                        Console.Write(array[oddRow, i] + " ");
                    }
                }
                oddRow = oddRow + 2;
            }
        }
        static void Main(string[] args)
        {
            int Row = 3, Column = 5;

            int[,] matrix = {
                                {1,2,3,4,5},
                                {6,7,8,9,10},
                                {11,12,13,14,15}
                            };
            PrintMatrixZigZag(Row, Column, matrix);
        }
    }
}
