using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method_IsGreaterThan
{
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            bool result1 = i.IsGreaterThan(10);
            Console.WriteLine("Result : {0} ", result1);

            int j = 5;
            bool result2 = j.IsGreaterThan(10);
            Console.WriteLine("Result : {0} ", result2);
        }
    }
}
