using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddFunctionOverloading
{
    class Program
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
        static void Main(string[] args)
        {
            Program P = new Program();

            int sum1 = P.Add(1,2);
            Console.WriteLine("Sum of 2 numbers is: " +sum1);

            int sum2 = P.Add(1,2,3);
            Console.WriteLine("Sum of 3 numbers is " +sum2);
        }
    }
}
