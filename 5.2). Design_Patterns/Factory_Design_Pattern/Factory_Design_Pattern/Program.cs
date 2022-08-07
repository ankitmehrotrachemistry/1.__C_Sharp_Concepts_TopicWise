using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    interface IFactory
    {
        void Details();
    }
    class PermanentEmployee : IFactory
    {
        public void Details()
        {
            Console.WriteLine("Permanent Job");
        }
    }
    class TemporaryEmployee : IFactory
    {
        public void Details()
        {
            Console.WriteLine("Temporary Job");
        }
    }
    abstract class EmployeeFactory
    {
        public abstract IFactory Factory(string employeeType);
    }
    class ConcreteEmployeeFactory : EmployeeFactory
    {
        public override IFactory Factory(string employeeType)
        {
            switch (employeeType)
            {
                case "PermanentEmployee":
                    return new PermanentEmployee();
                case "TemporaryEmployee":
                    return new TemporaryEmployee();
                default:
                    throw new ApplicationException(string.Format("Not Created"));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeFactory employeeFactory = new ConcreteEmployeeFactory();

            IFactory permanentEmployee = employeeFactory.Factory("PermanentEmployee");
            permanentEmployee.Details();

            IFactory temporaryEmployee = employeeFactory.Factory("TemporaryEmployee");
            temporaryEmployee.Details();
        }
    }
}
