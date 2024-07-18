using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Mapped_Property
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee 
                                    {
                                         EmployeeID = 1000,
                                         EmployeeName = "Ankit"
                                     };

            Console.WriteLine("Employee ID is {0} and Employee Name is {1}", employee.EmployeeID, employee.EmployeeName);
        }
    }
}
