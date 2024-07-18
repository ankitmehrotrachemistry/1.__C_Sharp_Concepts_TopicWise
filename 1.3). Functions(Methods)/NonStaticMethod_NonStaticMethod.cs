using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonStaticMethod
{
    public class A
    {
        public void Hello()
        {
            Console.WriteLine("Inside Hello");
        }
        public static void FunctionCall(A a)
        {
            a.Hello();
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            A a = new A();
            A.FunctionCall(a);
        }
    }
}
