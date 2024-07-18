using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass_T_Demo
{
    class Example<T>
    {
        T box;
        public T Box
        {
            set
            {
                this.box = value;
            }
            get
            {
                return this.box;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example<int> e = new Example<int>();
            e.Box = 23;
            Console.WriteLine(e.Box);

            Example<string> e1 = new Example<string>();
            e1.Box = "Ankit";
            Console.WriteLine(e1.Box);

            Example<double> d = new Example<double>();
            d.Box = 224;
            Console.WriteLine(d.Box);
        }
    }
}