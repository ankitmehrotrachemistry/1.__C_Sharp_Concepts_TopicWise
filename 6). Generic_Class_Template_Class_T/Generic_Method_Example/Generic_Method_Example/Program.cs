using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Method_Example
{
    class GenericClass
    {
        public void Show<T>(T msg) // Generic Method
        {
            Console.WriteLine(msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass gen1 = new GenericClass();

            gen1.Show("Generic Method");
            gen1.Show(10);
            gen1.Show("XO4");
        }
    }
}
