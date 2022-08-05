using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Class_Dictionary
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployee = new List<Employee>
            {
                new Employee { ID = 100, Name = "Ankit", Salary = 87845.50},
                new Employee { ID = 400, Name = "Chaaya", Salary = 187845.50},
                new Employee { ID = 800, Name = "Babita", Salary = 287845.50},
                new Employee { ID = 1600, Name = "Sippra", Salary = 487845.50}
            };
            Dictionary<int, Employee> dictionaryEmployee = listEmployee.ToDictionary(x => x.ID);

            foreach (KeyValuePair<int, Employee> KVP in dictionaryEmployee)
            {
                Console.WriteLine("Employee ID : " +KVP.Key + ", Employee Name : " + KVP.Value.Name + ", Employee Salary : " +KVP.Value.Salary);
            }
        }
    }
}
