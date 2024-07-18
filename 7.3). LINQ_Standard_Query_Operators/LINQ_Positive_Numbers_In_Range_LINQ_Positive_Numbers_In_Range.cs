using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Positive_Numbers_In_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,3,6,9,10,-4,2,-88,12,14};

            var myNumFound = from myNum in numbers
                             where myNum > 0
                             where myNum < 10
                             select myNum;

            Console.Write("\nNumbers within range of 1 to 10 are : \n");

            foreach (var num in myNumFound)
            {
                Console.Write("{0} ", num);
            }
        }
    }
}
