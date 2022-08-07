using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFunc
{
    class Program
    {
        public static int mymethod(int s, int d, int f, int g)
        {
            return s * d * f * g;
        }

        public static int mulMethod(int a, int b, int c)
        {
            return a * b * c;
        }
        static public void Main()
        {
            Func<int, int, int, int, int> val = mymethod;
            Console.WriteLine(val(10, 100, 1000, 1));

            Func<int, int, int, int> val1 = mulMethod;
            Console.WriteLine(val1(1, 2, 4));
        }
    }
}
