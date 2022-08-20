using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanFunction
{
    class Employee
    {
        bool _fired = false;
        bool _hired = true;
        int _salary = 10000;

        public bool IsCurrent()
        {
            return !this._fired &&
                this._hired &&
                this._salary > 0;
        }

        public bool IsExecutive()
        {
            return IsCurrent() &&
                this._salary > 1000000;
        }

        public bool Fired
        {
            get
            {
                return this._fired;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            if (employee.IsCurrent())
            {
                Console.WriteLine("Is currently employed");
            }
            if (employee.IsExecutive())
            {
                Console.WriteLine("Is an executive");
            }
            if (!employee.Fired)
            {
                Console.WriteLine("Is not fired yet");
            }
        }
    }
}
