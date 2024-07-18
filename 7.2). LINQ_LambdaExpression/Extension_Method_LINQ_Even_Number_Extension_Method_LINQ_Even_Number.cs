using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method_LINQ_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<int> EvenNumbers = Numbers.Where(num => num % 2 == 0);

            Console.WriteLine("Even Numbers in List are : ");

            foreach (int number in EvenNumbers)
                Console.WriteLine(number);
        }
    }
}
