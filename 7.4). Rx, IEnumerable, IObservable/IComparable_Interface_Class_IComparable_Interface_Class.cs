using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_Interface_Class
{
    public class Employee : IComparable
    {
        public int ID;
        public string EmployeeName;

        public Employee(int id, string employeeName)
        {
            this.ID = id;
            this.EmployeeName = employeeName;
        }

        public int CompareTo(object myObject)
        {
            Employee employee = myObject as Employee;

            return this.ID.CompareTo(employee.ID);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
                {
                    new Employee(1,"Soni"),
                    new Employee(5,"Rohit"),
                    new Employee(2,"Mohit"),
                    new Employee(4,"Pihu")
                };

            Console.WriteLine("Employee Array before Sorting : ");

            foreach (var emp in employees)
            {
                Console.WriteLine("ID : {0}, Name : {1}", emp.ID, emp.EmployeeName);
            }

            Array.Sort(employees);

            Console.WriteLine("Employee Array after Sorting : ");

            foreach (var emp in employees)
            {
                Console.WriteLine("ID : {0}, Name : {1}", emp.ID, emp.EmployeeName);
            }
        }
    }
}
