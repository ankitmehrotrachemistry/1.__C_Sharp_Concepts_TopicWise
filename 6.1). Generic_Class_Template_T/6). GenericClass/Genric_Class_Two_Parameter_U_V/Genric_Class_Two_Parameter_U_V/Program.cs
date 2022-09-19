using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genric_Class_Two_Parameter_U_V
{
    class Generic<U, V>
    {
        public U GenericVariable_1 { get; set; }
        public V GenericVariable_2 { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Generic<int, string> generic = new Generic<int, string>();

            generic.GenericVariable_1 = 100;
            generic.GenericVariable_2 = "Ankit Mehrotra";

            Console.WriteLine(generic.GenericVariable_1);
            Console.WriteLine(generic.GenericVariable_2);
        }
    }
}
