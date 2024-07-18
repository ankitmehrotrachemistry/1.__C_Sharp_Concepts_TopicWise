using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Abstraction
{
    abstract class AbstractClass
    {
        protected int _data;
        public void Print() // Non Abstract Method
        {
            Console.WriteLine("Hello World");
        }
        public abstract void Method();
    }
    class SubClass : AbstractClass
    {
        public SubClass(int data)
        {
            _data = data;
        }
        public override void Method()
        {
            Console.WriteLine("Data is : " +_data);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var obj1 = new AbstractClass(); 
            var obj = new SubClass(5);
            obj.Print(); // Calling Non-Abstract Method
            obj.Method();
        }
    }
}
