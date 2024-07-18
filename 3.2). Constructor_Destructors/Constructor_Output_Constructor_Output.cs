using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Output
{
    class ABC
    {
        public static void A()
        {
            Console.WriteLine("First Method");
        }
        public void B()
        {
            A();
            Console.WriteLine("Second Method");
        }
        public void B(int i)
        {
            Console.WriteLine(i);
            B();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ABC abc = new ABC();
            ABC.A();
            abc.B(20);
        }
    }
}
