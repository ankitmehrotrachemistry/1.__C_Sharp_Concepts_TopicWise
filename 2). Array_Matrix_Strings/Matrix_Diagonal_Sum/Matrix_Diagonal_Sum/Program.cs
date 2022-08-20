using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Diagonal_Sum
{
    class Matrix
    {
        int row, col;
        int[,] matrix = new int[10, 10];

        public void EnterMatrix()
        {
            Console.WriteLine("Enter Row");
            row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column");
            col = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Elements of Square Matrix 1 by 1");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matrix is :");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("\t{0}", matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
        public void SumOfDiagonalElements()
        {
            int sumOfDiagonal = 0;
            if (row == col)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (i == j)
                        {
                            sumOfDiagonal += matrix[i, j];
                        }
                    }
                }
                Console.WriteLine("Diagonal Sum is = {0}", sumOfDiagonal);
            }
            else
            {
                Console.WriteLine("Impossible Sum");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix mat = new Matrix();
            mat.EnterMatrix();
            mat.SumOfDiagonalElements();
        }
    }
}
