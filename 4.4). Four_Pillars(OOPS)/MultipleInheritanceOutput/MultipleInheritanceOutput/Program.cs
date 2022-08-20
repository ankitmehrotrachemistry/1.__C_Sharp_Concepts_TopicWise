using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceOutput
{
    public class A
    {
        public virtual void Func1()
        {
            Console.WriteLine("Inside Class A");
        }
    }
    public class B : A
    {
        public override void Func1()
        {
            Console.WriteLine("Inside Class B");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            A a2 = new B();
            B b = new B();
            a1.Func1();
            a2.Func1();
            b.Func1();
        }
    }
}
