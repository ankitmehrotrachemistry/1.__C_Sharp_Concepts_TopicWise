using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUTPUT_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, c = 10;
            
            Console.WriteLine("{0}, {0}", a, b);  // 10 10

            Console.WriteLine("{0}, {1}", a, b);  // 10 20

            Console.WriteLine("{1}, {1}", a, b);  // 20 20

            Console.WriteLine("{0} + {1}", a, b);

            Console.WriteLine(a == c);
        }
    }
}