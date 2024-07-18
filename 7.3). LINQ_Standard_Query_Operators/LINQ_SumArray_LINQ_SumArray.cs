using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_SumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = new int[] { 10, 30, 50, 40, 60, 20, 70, 90, 80, 100 };

            int total1 = arrayInt.Where(num => num > 50)
                                .Sum();

            int total2 = (from num in arrayInt
                          where num > 70
                          select num).Sum();

            Console.WriteLine("Sum of Integers > 50 is : " + total1);
            Console.WriteLine("Sum of Integers > 70 is : " + total2);
        }
    }
}
