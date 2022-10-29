using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Call_By_Reference
{
    class Program
    {
        public static void IncrementValue(ref int i)
        {
            i++;
        }
        public static void IncrementValue2(ref int i)
        {
            ++i;
        }
        static void Main(string[] args)
        {
            int x = 100;
            IncrementValue(ref x);
            Console.WriteLine(x); // Output : 101
            int y = 100;
            IncrementValue2(ref y);
            Console.WriteLine(y); // Output : 101
        }
    }
}