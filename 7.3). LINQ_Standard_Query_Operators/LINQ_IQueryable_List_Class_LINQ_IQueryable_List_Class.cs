using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_IQueryable_List_Class
{
    public class Employee
    {
        public int Employee_ID { get; set; }
        public string Employee_Name { get; set; }
        public string Employee_Gender { get; set; }
        public int Employee_Age { get; set; } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp1 = new List<Employee>()
            {
                new Employee() { Employee_ID = 1, Employee_Name = "Ankit", Employee_Age = 28, Employee_Gender = "Male"},
                new Employee() { Employee_ID = 4, Employee_Name = "Chaaya", Employee_Age = 18, Employee_Gender = "Female"},
                new Employee() { Employee_ID = 2, Employee_Name = "YungChu", Employee_Age = 32, Employee_Gender = "Male"},
                new Employee() { Employee_ID = 8, Employee_Name = "Sippra", Employee_Age = 24, Employee_Gender = "Female"},
                new Employee() { Employee_ID = 16, Employee_Name = "Vishnav", Employee_Age = 16, Employee_Gender = "Male"}
            };

            IQueryable<Employee> iQueryableEmp = emp1.AsQueryable()
                                                  .Where(x => x.Employee_Age > 22);
            foreach (var emp in iQueryableEmp)
            {
                Console.WriteLine($"Employee ID : {emp.Employee_ID} , Employee Name : {emp.Employee_Name} , " +
                                  $"Employee Age : {emp.Employee_Age} , Employee Gender : {emp.Employee_Gender}");
            }
        }
    }
}
