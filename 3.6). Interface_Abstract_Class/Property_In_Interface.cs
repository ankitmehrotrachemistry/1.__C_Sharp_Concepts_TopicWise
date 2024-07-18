using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_In_Interface
{
    interface IName
    {
        string Name { get; set; }
    }
    class Employee : IName
    {
        public string Name { get; set; }
    }
    class Company : IName
    {
        private string company { get; set; }
        public string Name
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IName emp1 = new Employee();
            emp1.Name = "Ankit";

            IName comp1 = new Company();
            comp1.Name = "Aristocrat";

            Console.WriteLine("{0} from {1} ", emp1.Name, comp1.Name);
        }
    }
}
