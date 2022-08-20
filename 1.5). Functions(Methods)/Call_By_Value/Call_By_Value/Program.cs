using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Call_By_Value
{
    class Program
    {
        public static void IncrementValue(int i)
        {
            i++;
        }
        public static void IncrementValue2(int i)
        {
            ++i;
        }
        static void Main(string[] args)
        {
            int x = 100;
            IncrementValue(x);
            Console.WriteLine(x);  // Output : 100

            int y = 100;
            IncrementValue2(y);
            Console.WriteLine(y);  // Output : 100

        }
    }
}
