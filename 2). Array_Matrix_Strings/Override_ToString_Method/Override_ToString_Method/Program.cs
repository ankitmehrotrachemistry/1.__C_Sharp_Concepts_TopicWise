using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_ToString_Method
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public ulong ID { get; set; }
        public override string ToString()
        {
            return "Person : " + Name + ", Age :" + Age + ", ID : " + ID; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Name = "Ankit", Age = 28, ID = 12776};
            Console.WriteLine(person);
        }
    }
}
