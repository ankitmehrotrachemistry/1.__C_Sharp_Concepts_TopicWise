using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_SecondLargest_SecondSmallest
{
    class Program
    {
        static void Main(string[] args)
        {
            var val = new int[] { 100, 12, 50, 44, 24};

            var maxNum = val.Max(x => x);
            Console.WriteLine("Maximum Number is : " +maxNum);

            var minNum = val.Min(x => x);
            Console.WriteLine("Minimum Number is : " +minNum);

            var secondMax = val.OrderByDescending(x => x).Skip(1).First();
            Console.WriteLine("Second Largest Number is : " +secondMax);

            var secondMin = val.OrderBy(x => x).Skip(1).First();
            Console.WriteLine("Second Smallest Number is : " +secondMin);
            
        }
    }
}
