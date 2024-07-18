using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Generic
{
    public class Person
    {
        public int Id { get; set; }
    }
    public class Employee : Person
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public decimal Salary { get; set; }
    }
    class Program
    {
        public delegate bool AreEqual<T>(T a, T b);
        private static bool AreEqualGeneric<T>(T x, T y) where T : Employee
        {
            return (x.EmployeeId == y.EmployeeId) ? true : false;
        }
        static void Main(string[] args)
        {
            var e1 = new Employee() { EmployeeId = 1 };
            var e2 = new Employee() { EmployeeId = 2 };
            var e3 = new Employee() { EmployeeId = 1 };

            var isObjRefEqual = e1.Equals(e2);
            var isEmployeeIdEqual = AreEqualGeneric(e1, e3);

            Console.WriteLine(String.Format("isObjRefEqual = {0}", isObjRefEqual));
            Console.WriteLine(String.Format("isEmployeeIdEqual = {0}", isEmployeeIdEqual));
        }
    }
}
