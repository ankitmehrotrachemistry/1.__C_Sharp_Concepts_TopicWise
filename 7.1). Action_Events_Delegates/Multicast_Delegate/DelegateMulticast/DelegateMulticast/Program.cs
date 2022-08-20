using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMulticast
{
    class Program
    {
        public delegate void AddDelegate(int num1, int num2);
        public static void Add(int a, int b)
        {
            int result;
            result = a + b;

            Console.WriteLine(result);
        }
        public static void Add100(int a, int b)
        {
            int result;
            result = a + b + 100;

            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            AddDelegate d1 = Add;

            d1 += Add100;
            d1 += (int a, int b) =>
            {
                int res = (a + b) * 1000;
                Console.WriteLine(res);
            };

            d1(10, 20);
        }
    }
}
