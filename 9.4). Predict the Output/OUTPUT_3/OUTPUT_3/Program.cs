using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUTPUT_3
{
    class ClassA
    {
        public ClassA() : this(4)
        {
            Console.WriteLine("Non-Parameter");
        }
        public ClassA(int pValue)
        {
            Console.WriteLine("Parameter");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassA refA = new ClassA();

            //ClassA refB = new ClassA(4);
        }
    }
}
