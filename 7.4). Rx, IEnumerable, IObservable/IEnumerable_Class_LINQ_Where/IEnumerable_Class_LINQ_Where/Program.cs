using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_Class_LINQ_Where
{
    public class Employee
    {
        public int id;
        public int salary;
        public string name;
        public string department;

        public override string ToString()
        {
            return id + " " + name + " " + salary + " " + department;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee { id = 10, name = "Ankit", salary = 100000, department = "GameDev"},
                new Employee { id = 20, name = "Sachin", salary = 120000, department = "Project"},
                new Employee { id = 40, name = "Nitin", salary = 140000, department = "Manager"},
                new Employee { id = 50, name = "Kartik", salary = 180000, department = "Developer"},
            };

            IEnumerable<Employee> result = emp.Where(x => x.name[0] == 'K');

            Console.WriteLine("ID  Name  Salary  Department");
            Console.WriteLine("----------------------------");

            foreach (Employee e in result)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
