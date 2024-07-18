using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_OddNumber_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Enumerable.Range accepts two parameters: Start and Count.
            //  So if you want to generate numbers from 20 to 60 (inclusive of both),
            //  you would say Enumerable.Range(20,40) since the second parameter is
            //  the number of sequential integers to generate.

            IEnumerable<int> oddNumbers = Enumerable.Range(20, 40).Where(x => x % 2 != 0);

            foreach (int n in oddNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}


