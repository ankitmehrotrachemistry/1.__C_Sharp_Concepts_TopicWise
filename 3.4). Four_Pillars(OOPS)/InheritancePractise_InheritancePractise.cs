using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractise
{
    public class A
    {
        public void Func()
        {
            Console.WriteLine("Inside A");
        }
    }
    public class B : A
    {
        public new void Func()
        {
            Console.WriteLine("Inside B");
        }
    }
    public class C : B
    {
        public new void Func()
        {
            Console.WriteLine("Inside C");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Func();

            A a1 = new B();
            a1.Func();

            B b = new B();
            b.Func();

            C c = new C();
            c.Func();

            C c1 = new B();
            c1.Func();
        }
    }
}
