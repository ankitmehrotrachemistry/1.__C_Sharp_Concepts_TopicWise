using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity_Matrix
{
    // In Square Matrix if diagonal Element is 1 and rest all elements are 0,
    // it is called as Identitiy Matrix.
    
    class Program
    {
        static bool IsIdentityMatrix(int[,] mat, int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j && mat[i, j] != 1)
                        return false;
                    else if (i != j && mat[i, j] != 0)
                        return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[,] matrix = new int[10,10];
            int row, col;

            Console.WriteLine("Enter the Order of Square Matrix : ");
            row = Convert.ToInt32(Console.ReadLine());
            col = row;

            Console.WriteLine("Enter Elements of Matrix");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("Element[{0}],[{1}] : ", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The Matrix is :");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(" {0} ", matrix[i,j]);
                }
                Console.Write("\n");
            }

            if (IsIdentityMatrix(matrix, row))
                Console.WriteLine("It is Identity Matrix");
            else
                Console.WriteLine("It is not an Identity Matrix");

        }
    }
}
