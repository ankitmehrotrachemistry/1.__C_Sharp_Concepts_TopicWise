using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IList_Generic_Person
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>();

            person.Add(new Person { ID = 1, Name = "Saurabh", SurName = "Kumar" });
            person.Add(new Person { ID = 2, Name = "Ankit", SurName = "Tiwari" });
            person.Add(new Person { ID = 3, Name = "Chaaya", SurName = "Malhotra" });
            person.Add(new Person { ID = 4, Name = "Bubbly", SurName = "Sinha" });

            foreach (Person p in person)
            {
                Console.WriteLine(p.ID + " " +p.Name + " " + p.SurName);
            }
        }
    }
}
