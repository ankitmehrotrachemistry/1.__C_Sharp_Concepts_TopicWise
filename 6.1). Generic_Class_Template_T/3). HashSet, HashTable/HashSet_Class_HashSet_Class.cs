using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_Class
{
    public class Employee
    {
        public int Employee_ID { get; set; }
        public string Employee_Name { get; set; }
        public string Employee_Department { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Employee> employees = new HashSet<Employee> 
            {
                new Employee { Employee_ID = 12, Employee_Name = "Sippra", Employee_Department = "CSE"},
                new Employee { Employee_ID = 12, Employee_Name = "Sippra", Employee_Department = "CSE"},
                new Employee { Employee_ID = 8, Employee_Name = "Kaaju", Employee_Department = "Mech"},
                new Employee { Employee_ID = 24, Employee_Name = "JohnCena", Employee_Department = "Civil"}
            };
            Console.WriteLine("{0,6}{1,2}{2,3}", "Emp_ID","","Emp_Name","Emp_Dept");
            Console.WriteLine("=========================================================");
            foreach (var employee in employees)
            {
                Console.WriteLine("{0,-8}{1,-10}{2,10}", employee.Employee_ID, employee.Employee_Name, employee.Employee_Department);
            }
            Console.WriteLine("=========================================================");
        }
    }
}
