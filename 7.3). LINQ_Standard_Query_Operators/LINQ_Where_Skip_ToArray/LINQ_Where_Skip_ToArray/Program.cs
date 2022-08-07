using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Where_Skip_ToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1,2,6,7,8,9,10,3,4,5};

            // Numbers Greater than 4 are : 6 7 8 9 10 5
            // Skip(3) will skip 6 7 8 and will return 9 10 5

            var num1 = numbers.Where(x => x > 4).Skip(3).ToArray();

            foreach (int i in num1)
            {
                Console.WriteLine(i);
            }

            /*var num2 = numbers.Skip(3).ToArray();

            foreach (int i in num2)
            {
                Console.WriteLine(i);
            }*/
        }
    }
}
