using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Named_Parameters
{
    class Program
    {
        public static void NamedParameterFunction(string firstName, string lastName)
        {
            Console.WriteLine($"Full Name : {firstName} {lastName}");
        }
        static void Main(string[] args)
        {
            NamedParameterFunction("Ankit", "Mehrotra");
            NamedParameterFunction(firstName:"Rahul", lastName:"Kumar");
            NamedParameterFunction(lastName:"Khandelwal", firstName:"Suruchi");
        }
    }
}
