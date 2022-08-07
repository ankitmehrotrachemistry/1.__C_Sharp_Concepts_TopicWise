using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Dimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intArray = new int[4, 2] 
                                  { 
                                     {8,4},
                                     {4,6},
                                     {1,2},
                                     {5,6}
                                  };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("intArray[{0},{1}] = {2}", i, j, intArray[i,j]);
                }
            }
        }
    }
}
