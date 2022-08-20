using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorBasic
{
    public class Employee
    {
        public int age;
        public string name;
        public Employee()
        {
            
        }
    }
    class Program : Employee
    {
        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.age = 12;
            obj.name = "John";

            Console.WriteLine("Age is " + obj.age);
            Console.WriteLine("Name is " +obj.name);
        }
    }
}
