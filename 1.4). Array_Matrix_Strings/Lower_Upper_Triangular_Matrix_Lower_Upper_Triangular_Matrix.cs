using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lower_Upper_Triangular_Matrix
{
    class Program
    {
        static void LowerTriangularMatrix(int[,] Matrix, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i < j)
                    {
                        Console.Write("0" + " ");
                    }
                    else
                    {
                        Console.Write(Matrix[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void UpperTriangularMatrix(int[,] Matrix, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i > j)
                    {
                        Console.Write("0" + " ");
                    }
                    else
                    {
                        Console.Write(Matrix[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] Matrix = {
                                {1,2,3},
                                {4,5,6},
                                {7,8,9}
                            };
            int ROW = 3, COL = 3;

            Console.WriteLine("Lower Triangular Matrix : ");
            LowerTriangularMatrix(Matrix, ROW, COL);

            Console.WriteLine("Upper Triangular Matrix : ");
            UpperTriangularMatrix(Matrix, ROW, COL);
        }
    }
}
