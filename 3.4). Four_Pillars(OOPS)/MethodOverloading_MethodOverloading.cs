using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MethodOverloading
{
    class MethodOverloading
    {
        // adding two integer values.
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        // adding three integer values.
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
        public double Add(double a, double b)
        {
            double sum = a + b;
            return sum;
        }
        // Main Method
        public static void Main(String[] args)
        {
            // Creating Object
            MethodOverloading ob = new MethodOverloading();
            // ------------------------
            int sum1 = ob.Add(1, 2);
            Console.WriteLine("sum of the two "
                              + "integer value : " + sum1);
            // ------------------------
            int sum2 = ob.Add(1, 2, 3);
            Console.WriteLine("sum of the three "
                              + "integer value : " + sum2);
            // ------------------------
            double sum3 = ob.Add(2.0, 5.4);
            Console.WriteLine("sum of the two "
                          + "double value : " + sum3);
        }
    }
}