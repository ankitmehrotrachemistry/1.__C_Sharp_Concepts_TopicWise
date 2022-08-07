using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Design_Pattern
{
    class Employee
    {
        public List<string> GetEmployeeList()
        {
            List<string> EmployeeList = new List<string>();

            EmployeeList.Add("Ankit");
            EmployeeList.Add("Chaaya");
            EmployeeList.Add("Bubbly");
            EmployeeList.Add("Diana");

            return EmployeeList;
        }
    }
    interface ITarget
    {
        List<string> GetEmployees();
    }
    class EmployeeAdapter : Employee, ITarget
    {
        public List<string> GetEmployees()
        {
            return GetEmployeeList();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Employee List ---------");

            ITarget adapter = new EmployeeAdapter();

            foreach (string employee in adapter.GetEmployees())
            {
                Console.WriteLine(employee);
            }
        }
    }
}
