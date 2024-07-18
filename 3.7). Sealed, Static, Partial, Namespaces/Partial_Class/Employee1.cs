using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    public partial class Employee
    {
        public Employee(int id, string name)
        {
            this.EmpId = id;
            this.EmpName = name; 
        }
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Employee ID is : " + this.EmpId + " and Employee Name is : " + this.EmpName);
        }
    }
}
