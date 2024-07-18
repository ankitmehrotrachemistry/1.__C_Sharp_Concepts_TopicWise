using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aristo_ArrayLinqFromSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 5,4,1,2,9,8,6,0,10};

            var num = from n in number
                      select n;

            Console.WriteLine("Print It");

            foreach (var v in num)
            {
                Console.WriteLine(v);
            }

            //  Even Number in LINQ

            int[] number1 = { 5, 4, 1, 2, 9, 8, 6, 0, 10 };

            var num1 = (from n in number1
                        where(n % 2 == 0)
                        select n);

            Console.WriteLine("Even Number is : ");
            Console.WriteLine(num1);
        }
    }
}
