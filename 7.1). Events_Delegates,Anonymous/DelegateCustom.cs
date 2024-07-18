using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCustom
{
    class Program
    {
        public delegate int my_delegate(int a, int b, int c, int d);
        public static int my_method(int a, int b, int c, int d)
        {
            return a * b * c * d;
        }
        static void Main(string[] args)
        {
            my_delegate del = my_method;

            Console.WriteLine(del(2,4,6,8));
        }
    }
}
