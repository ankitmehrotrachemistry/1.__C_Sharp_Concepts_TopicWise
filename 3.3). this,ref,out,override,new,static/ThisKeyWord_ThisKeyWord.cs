using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyWord
{
    class Employee
    {
        private string name;
        public Employee(string name)
        {
            this.name = name;
        }
        public void PrintValue()
        {
            Console.WriteLine("Name is : " +name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee E = new Employee("Ankit");
            E.PrintValue();
        }
    }
}
