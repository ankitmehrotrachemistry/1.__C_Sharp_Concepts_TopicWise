using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Variable
{
    class Program
    {
        static void GetEmployeeDetail(out string EmployeeName, out string Gender, out long Salary, out string Department)
        {
            EmployeeName = "Ankit";
            Gender = "Male";
            Salary = 1000000;
            Department = "CSE";
        }
        static void Main(string[] args)
        {
            string EmployeeName, Gender, Department;
            long Salary;

            GetEmployeeDetail(out EmployeeName, out Gender, out Salary, out Department);

            Console.WriteLine("Employee Details are :-");

            Console.WriteLine("Name : {0}, Gender : {1}, Salary : {2}, Department : {3}", EmployeeName, Gender, Salary, Department);
        }
    }
}