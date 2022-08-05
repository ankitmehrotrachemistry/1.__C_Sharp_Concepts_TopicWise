using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Commands_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElem = new int[7] {12,2,10,54,98,4,48};

            var linqElemAverage = arrayElem.Average(x => x);
            Console.WriteLine("Average of Array : " +linqElemAverage);

            var linqElemCount = arrayElem.Count();
            Console.WriteLine("Number of Elements in Array : " +linqElemCount);

            var linqElemBool = arrayElem.Contains(12);
            Console.WriteLine("Bool Is Element in Array ? : " +linqElemBool);

            var linqElemGetType = arrayElem.GetType();
            Console.WriteLine("Type of Element in Array : " + linqElemGetType);

            var linqElemReverse = arrayElem.Reverse();
            Console.Write("Reversed Array is : ");
            foreach (var elem in linqElemReverse)
            {
                Console.Write(elem + ", ");
            }
            Console.WriteLine();

            var linqElemSumOfArray = arrayElem.Sum(x => x);
            Console.WriteLine("Sum of Elements of Array : " +linqElemSumOfArray);

            var linqElem1 = arrayElem.Skip(2);
            Console.Write("Array after skipping 2 is : ");
            foreach (var elem in linqElem1)
            {
                Console.Write(elem + ", ");
            }
            Console.WriteLine();
        }
    }
}
