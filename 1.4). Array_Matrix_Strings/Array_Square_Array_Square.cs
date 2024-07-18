using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            int[] squ = new int[4];
            // Finding square of Elements 
            Console.Write("Square of Elements : ");
            for (int i = 0; i < arr.Length; i++)
            {
                squ[i] = arr[i] * arr[i];
                Console.Write(squ[i] + " ");
            }
            Console.WriteLine(" ");
        }
    }
}