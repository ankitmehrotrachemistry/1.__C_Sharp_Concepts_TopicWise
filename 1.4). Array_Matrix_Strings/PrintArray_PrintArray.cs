using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintArray
{
    class PrintArrayExample
    {
        static void Main(string[] args)
        {
            int[] x = { 10, 20, 30, 40, 50 };
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(x[i]);
            }
        }
    }
}
