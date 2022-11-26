using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEqualityComparer_Interface_Class
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class PersonNameComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            return x.FirstName == y.FirstName &&
                   x.LastName == y.LastName;
        }

        public int GetHashCode(Person obj)
        {
            return obj.Id.GetHashCode() ^ (obj.FirstName == null ? 0 : obj.FirstName.GetHashCode())
                                        ^ (obj.LastName == null ? 0 : obj.LastName.GetHashCode());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = {
                  new Person() {FirstName = "Steve", LastName = "Jobs"},
                  new Person() {FirstName = "Ankit", LastName = "Mehrotra"},
                  new Person() {FirstName = "Steve", LastName = "Jobs"},
                  new Person() {FirstName = "Larry", LastName = "Page"},
                  new Person() {FirstName = "Chaaya", LastName = "Mishra"}
            };

            var distictPeople = people.Distinct(new PersonNameComparer()).ToArray();

            Array.ForEach(distictPeople,
                          x => Console.WriteLine(x.FirstName + " " + x.LastName));
        }
    }
}
