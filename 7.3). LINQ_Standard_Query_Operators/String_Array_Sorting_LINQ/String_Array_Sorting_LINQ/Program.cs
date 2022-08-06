using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Array_Sorting_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testName = new string[] {"ankit", "alok", "abhishek", "avinash"};

            Array.Sort(testName, StringComparer.InvariantCulture);

            Array.ForEach(testName, x => Console.WriteLine(x));
        }
    }
}