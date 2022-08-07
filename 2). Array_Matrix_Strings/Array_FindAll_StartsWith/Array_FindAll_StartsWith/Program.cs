using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_FindAll_StartsWith
{
    class Program
    {
        public static void PrintIndexAndValue(String[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string[] myArray = {"Sun", "Mon", "Tue", "Sat"};
            Console.WriteLine("Initial Array is : ");
            PrintIndexAndValue(myArray);

            string[] value = Array.FindAll(myArray,
                                           x => x.StartsWith("S", StringComparison.Ordinal));

            Console.WriteLine("Elements starting with 'S' are :");
            PrintIndexAndValue(value);
        }
    }
}
