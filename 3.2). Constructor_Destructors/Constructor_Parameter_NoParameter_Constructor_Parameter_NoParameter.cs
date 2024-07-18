using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Parameter_NoParameter
{
    public class Person
    {
        public string Name { get; }
        public Person()
        {
            Name = "Ankit";
        }
        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person();
            Console.WriteLine(person1.Name);

            var person2 = new Person("Chaaya");
            Console.WriteLine(person2.Name);

            Console.WriteLine(person2);
        }
    }
}
