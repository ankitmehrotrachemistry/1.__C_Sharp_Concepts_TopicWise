using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_Bool_Function
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string PlayerID { get; set; }

        public override bool Equals(object obj)
        {
            var person = obj as Person;
            return Name == person.Name && Age == person.Age && PlayerID == person.PlayerID;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() * Age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person { Name = "Ankit", Age = 12, PlayerID = "XO-1" };
            var person2 = new Person { Name = "Ankit", Age = 12, PlayerID = "XO-1" };
            var person3 = new Person { Name = "Ankit", Age = 10, PlayerID = "XO-2" };

            bool result1 = person1.Equals(person2);
            bool result2 = person1.Equals(person3);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
