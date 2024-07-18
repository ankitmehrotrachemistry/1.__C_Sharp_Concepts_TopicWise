using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Intersect_Union_OrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data1 = new List<int>() { 10, 20, 30, 40, 50, 60, 70 };
            List<int> data2 = new List<int>() { 50, 60, 70, 80, 90, 100, 110 };

            var finalIntersection = data1.Intersect(data2).OrderBy(i => i);

            Console.WriteLine("Final Intersection Result is : ");

            foreach (var j in finalIntersection)
            {
                Console.WriteLine(j + " ");
            }

            var finalUnion = data1.Union(data2).OrderBy(i => i);

            Console.WriteLine("Final Union Result is : ");

            foreach (var j in finalUnion)
            {
                Console.WriteLine(j + " ");
            }
        }
    }
}
