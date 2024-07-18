using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2, y = 4;
            var res = x > y ? "x is greater than y" : "x is less than y";
            Console.WriteLine(res);
        }
    }
}
