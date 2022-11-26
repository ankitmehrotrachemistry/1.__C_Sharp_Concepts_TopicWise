using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_IEnumerable_Number
{
    class Program
    {
        delegate bool MyDelegate(int n);
        static bool LessThanFive(int n) { return n < 5; }
        static bool GreaterThanTwelve(int n) { return n > 12; }

        static IEnumerable<int> IterationOfNumbers(IEnumerable<int> numbers, MyDelegate myDel)
        {
            foreach (int number in numbers)
                if (myDel(number))
                    yield return number;
        }
        static void Main(string[] args)
        {
            int[] numbers = new[] {1,2,5,8,12,4,0,18,16,14};

            IEnumerable<int> result1 = IterationOfNumbers(numbers, GreaterThanTwelve);
            foreach (int n in result1)
                Console.WriteLine("Number Greater than 12 are : " +n);

            IEnumerable<int> result2 = IterationOfNumbers(numbers, LessThanFive);
            foreach (int n in result2)
                Console.WriteLine("Numbers less than 5 are : " +n);
        }
    }
}
