using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 2, 7, 5, 9, 1, 5, 3, 1, 7, 6, 5 , 10, 4, 5 };

            var count = numbers.Count(x => 
                              { 
                                   return x == 5; 
                               });
            Console.WriteLine(count); // Total Number of 5 in List

            var sumOfAll = numbers.Sum(x=>x);
            Console.WriteLine(sumOfAll);

            var maximum = numbers.Max(x=>x);
            Console.WriteLine(maximum);

            var average = numbers.Average(x => x);
            Console.WriteLine(average);

            var m = numbers.Where(x => x > 2).Count();
            Console.WriteLine(m);

            var product = numbers.Aggregate(2,(x, y) => x*y);
            Console.WriteLine(product);
        }
    }
}
