using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Parameter_Return_Type
{
    class Program
    {
        public string Display(string name)
        {
            Console.WriteLine("Parameter Function with Return Type : ");
            return name;
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            string n = p.Display("Ankit");

            Console.WriteLine("Hello " +n);
        }
    }
}
