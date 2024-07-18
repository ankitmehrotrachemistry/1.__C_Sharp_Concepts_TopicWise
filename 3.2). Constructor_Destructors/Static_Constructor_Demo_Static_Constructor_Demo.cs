using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor_Demo
{
    class Car
    {
        static Car()
        {
            // Executed only once for all instances.
            Console.WriteLine("Inside Static Constructor");
        }
        public Car()
        {
            Console.WriteLine("Default Constructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car carObj1 = new Car();
            Console.WriteLine();
            Car carObj2 = new Car();
        }
    }
}
