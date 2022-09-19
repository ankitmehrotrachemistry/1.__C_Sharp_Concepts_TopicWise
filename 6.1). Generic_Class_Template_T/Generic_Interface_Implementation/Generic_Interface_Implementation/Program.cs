using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Interface_Implementation
{
    public interface ICounter<T>
    {
        int Count { get; }
        T Get(int index);
    }
    public interface IPerson<T> : ICounter<T>
    {
        void Add(T item);
    }
    public class People<T> : IPerson<T>
    {
        private int size;
        private T[] persons;

        public People()
        {
            size = 0;
            persons = new T[10];
        }
        public int Count { get { return size; } }
        public void Add(T pers)
        {
            persons[size] = pers;
            size++;
        }
        public T Get(int index) { return persons[index]; }
    }
    public class Employee
    {
        public long EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee(long number = 0, string fName = "Ankit", string lName = "Mehrotra")
        {
            EmployeeNumber = number;
            FirstName = fName;
            LastName = lName;
        }
        public override string ToString()
        {
            base.ToString();

            return string.Format("Employee : {0}\n First Name : {1}\n"+
                                 "Last Name : {2}",
                                  EmployeeNumber, FirstName,
                                  LastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IPerson<Employee> employees = new People<Employee>();

            Employee emp1 = null;

            emp1 = new Employee();
            emp1.EmployeeNumber = 543534;
            emp1.FirstName = "Chaaya";
            emp1.LastName = "Mishra";
            employees.Add(emp1);

            emp1 = new Employee();
            emp1.EmployeeNumber = 5349874;
            emp1.FirstName = "Sakshi";
            emp1.LastName = "Kumari";
            employees.Add(emp1);

            emp1 = new Employee();
            emp1.EmployeeNumber = 98765432;
            emp1.FirstName = "Danny";
            emp1.LastName = "Michael";
            employees.Add(emp1);

            for (int i = 0; i < employees.Count; i++)
            {
                Employee staff = employees.Get(i);

                Console.WriteLine("---------------------------------");

                Console.WriteLine("Employee : {0}", staff.EmployeeNumber);
                Console.WriteLine("First Name : {0}", staff.FirstName);
                Console.WriteLine("Last Name : {0}", staff.LastName);
            }
        }
    }
}
