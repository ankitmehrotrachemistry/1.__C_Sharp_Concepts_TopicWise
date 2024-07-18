using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_And_Generic_List
{
    class Customer
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                EmpID = 1,
                EmpName = "Ankit",
                EmpSalary = 50000
            };
            Customer customer2 = new Customer()
            {
                EmpID = 2,
                EmpName = "Chaaya",
                EmpSalary = 500000
            };
            List<Customer> Customers = new List<Customer>(2);

            Customers.Add(customer1);
            Customers.Add(customer2);

            foreach (Customer c in Customers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.EmpID, c.EmpName, c.EmpSalary);
            }
        }
    }
}
