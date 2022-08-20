using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNoOperator
{
    class Program
    {
        public static int add(int x, int y)
        {
            int z;
            while (y != 0)
            {
                z = x & y;
                x = x ^ y;
                y = z << 1;
            }
            return x;
        }
        static void Main(string[] args)
        {
            int a, b, sum;
            Console.WriteLine("Enter the 2 numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            sum = add(a,b);
            Console.WriteLine("Sum = " + sum);
        }
    }
}