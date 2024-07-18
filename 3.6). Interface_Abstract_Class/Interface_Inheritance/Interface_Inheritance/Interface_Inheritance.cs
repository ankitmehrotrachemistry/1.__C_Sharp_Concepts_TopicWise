using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Inheritance
{
    public interface IBaseInterface
    {
        void BaseFunction();
    }
    public interface IMyInterface : IBaseInterface
    {
        void MyFunction();
    }
    class Program : IMyInterface
    {
        public void BaseFunction()
        {
            Console.WriteLine("Base Function Implementation");
        }
        public void MyFunction()
        {
            Console.WriteLine("My Function Implementation");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program myProgram = new Program();
            myProgram.BaseFunction();
            myProgram.MyFunction();
        }
    }
}
