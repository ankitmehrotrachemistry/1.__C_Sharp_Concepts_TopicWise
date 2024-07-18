using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;
namespace Lamda_As_Parameter_In_Method
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public static class PersonExtensions
    {
        public static void GenerateRandomName(this Person person, Func<Person> action)
        {
            var randomPerson = action();
            person.FirstName = randomPerson.FirstName;
            person.LastName = randomPerson.LastName;
        }
        public static void Mutate(this Person person, Func<string, string> action)
        {
            person.FirstName = action(person.FirstName);
            person.LastName = action(person.LastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var randomPerson = new Person();
            randomPerson.GenerateRandomName(() =>
            {
                return new Person()
                {
                    FirstName = Name.First(),
                    LastName = Name.Last()
                };
            });
            Console.WriteLine($"{randomPerson.FirstName} {randomPerson.LastName}"); 
            randomPerson.Mutate(x => x.ToUpper());
            Console.WriteLine($"{randomPerson.FirstName} {randomPerson.LastName}"); 
        }
    }
}
