using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassDelegateToMethod
{
    class Program
    {
        public delegate int MyDelegate(int x, int y);
        static void Display(MyDelegate del)
        {
            Console.WriteLine(del(4,8));
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            MyDelegate del1 = new MyDelegate(Add);

            Display(del1);
        }
    }
}
