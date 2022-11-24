using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            Action act = () => 
            { 
                Console.WriteLine("No Parameter"); 
            };
            Action<int> actOneParameter = (arg1) => 
            { 
                Console.WriteLine("Par: " +arg1); 
            };
            Action<int, int> actTwoParameter = (arg1, arg2) => 
            { 
                Console.WriteLine("Par1: " +arg1+ ", Par2: " +arg2); 
            };

            act();
            actOneParameter(10);
            actTwoParameter(20,40);
        }
    }
}
