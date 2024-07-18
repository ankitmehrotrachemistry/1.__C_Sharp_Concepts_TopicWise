using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Inherit_Interface
{
    public interface IInterface1
    {
        void Function1();
        void Function2();
    }
    public interface IInterface2 : IInterface1
    {
        void Function3();
    }
    class Test : IInterface2
    {
        public void Function1()
        {
            Console.WriteLine("Inside Function 1");
        }
        public void Function2()
        {
            Console.WriteLine("Inside Function 2");
        }
        public void Function3()
        {
            Console.WriteLine("Inside Function 3");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.Function1();
            t.Function2();
            t.Function3();
        }
    }
}
