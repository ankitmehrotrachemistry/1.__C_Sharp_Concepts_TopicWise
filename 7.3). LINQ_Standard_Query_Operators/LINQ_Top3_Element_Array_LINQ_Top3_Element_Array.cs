using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Top3_Element_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElement = new int[7] { 1,5,2,8,10,6,16 };

            var topThree = arrayElement.OrderByDescending(i => i)
                                       .Take(3);

            foreach (var x in topThree)
            {
                Console.WriteLine(x);
            }
        }
    }
}
