using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_2DArray
{
    class Program
    {
        static int[,] grid = new int[20,20];

        public static IEnumerable<int> IGridValue()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    yield return grid[i,j];
                }
            }
        }
        static void Main(string[] args)
        {
            grid[1, 1] = 2;
            grid[8, 0] = 10;
            grid[0, 5] = 24;
            grid[6, 8] = 44;

            int sum = 0;

            foreach (int value in IGridValue())
            {
                sum += value;
            }
            Console.WriteLine("Sum of these Elements :" +sum);
        }
    }
}
