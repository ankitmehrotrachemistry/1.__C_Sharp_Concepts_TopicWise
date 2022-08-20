using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_Keyword_Class
{
    public class Employee
    {
        public int id;
        public string name;
        public float salary;
        public Employee(int id, string name, float salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void Display()
        {
            Console.WriteLine("Employee Details are : ID = " +id+ " , Name = " +name+ " , Salary = "+salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(100,"Ankit",86845.5f);
            Employee emp2 = new Employee(200, "Chaaya", 184004.80f);

            emp1.Display();
            emp2.Display();
        }
    }
}
