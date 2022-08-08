using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {
                1, 3, 6, 9, 10, -4, -2, -3, -88, 12, 19,  14
            };

            var nQuery =
            from VrNum in numbers
            where VrNum > 0
            where VrNum < 10
            select VrNum;
            Console.Write("\nThe numbers within the range of 1 to 10 are : \n");
            foreach (var VrNum in nQuery)
            {
                Console.Write("{0}  ", VrNum);
            }
            Console.ReadLine();
        }
    }
}
