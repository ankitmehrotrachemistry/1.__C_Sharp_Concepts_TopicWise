using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_OrderByDescending
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1,-2,3,0,-4,5};

            var posNums = from n in nums
                          where n > -5 && n < 6
                          orderby n descending
                          select n;

            foreach (int i in posNums)
                Console.Write(i + " ");

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
