using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneLinerEvenFunction
{
    class Program
    {
        static long TotalSumOfEvenNumbers(int[] intArray)
        {
            return intArray.Where(i => i % 2 == 0).Sum(i => (long)i);
        }
        
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 2, 5, 7, 9, 10 };

            Console.WriteLine(TotalSumOfEvenNumbers(array1));
        }
    }
}
