using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_IEnumerable
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {ID = 101, FirstName = "Preety", LastName = "Tiwary", Salary = 60000 },
                new Employee {ID = 102, FirstName = "Priyanka", LastName = "Dewangan", Salary = 70000 },
                new Employee {ID = 103, FirstName = "Hina", LastName = "Sharma", Salary = 80000 },
                new Employee {ID = 104, FirstName = "Anurag", LastName = "Mohanty", Salary = 90000 },
                new Employee {ID = 105, FirstName = "Sambit", LastName = "Satapathy", Salary = 100000 },
                new Employee {ID = 106, FirstName = "Sushanta", LastName = "Jena", Salary = 160000 }
            };
            return employees;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> basicQuery = (from emp in Employee.GetEmployees()
                                         select emp).ToList();
            foreach (Employee emp in basicQuery)
            {
                Console.WriteLine($"ID : {emp.ID} Name : {emp.FirstName} {emp.LastName}");
            }

            Console.WriteLine();

            IEnumerable<Employee> basicMethod = Employee.GetEmployees().ToList();

            foreach (Employee emp in basicMethod)
            {
                Console.WriteLine($"ID : {emp.ID} Name : {emp.FirstName} {emp.LastName}");
            }

            Console.ReadKey();
        }
    }
}
