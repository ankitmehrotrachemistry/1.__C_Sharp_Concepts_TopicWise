using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_Square_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> squares = Enumerable.Range(1,10).Select(x=>x*x);

            foreach(int num in squares)
            {
                Console.WriteLine(num);
            }
        }
    }
}
