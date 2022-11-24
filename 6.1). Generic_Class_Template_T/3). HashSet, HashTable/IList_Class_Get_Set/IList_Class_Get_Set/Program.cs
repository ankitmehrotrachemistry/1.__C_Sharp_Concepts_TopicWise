using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IList_Class_Get_Set
{
    class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Ankit";
            p1.SurName = "Mehrotra";

            IList list = new List<Person>();
            list.Add(p1);

            // Typecasting the Class

            Console.WriteLine( ((Person)list[0]).Name + " " + ((Person)list[0]).SurName);
        }
    }
}
