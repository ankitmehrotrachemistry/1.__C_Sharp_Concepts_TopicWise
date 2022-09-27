using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Example
{
    class Window
    {
        public int Row { get; set; }
        public int Column { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Window window = new Window();

            window.Row = 3;
            window.Column = 3;

            int[,] array = { {1,2,3}, {4,5,6}, {7,8,9} };

            for (int i = 0; i < window.Row; i++)
            {
                for (int j = 0; j < window.Column; j++)
                {
                    Console.Write(array[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
