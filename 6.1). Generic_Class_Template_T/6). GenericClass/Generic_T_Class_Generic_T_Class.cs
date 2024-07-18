using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_T_Class
{
    class Program
    {
        public class GenericClass<T>
        {
            public void PrintFunc(T item)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            GenericClass<int> intData = new GenericClass<int>();
            intData.PrintFunc(10);

            GenericClass<string> stringData = new GenericClass<string>();
            stringData.PrintFunc("Ankit");

            GenericClass<double> doubleData = new GenericClass<double>();
            doubleData.PrintFunc(1188);

            GenericClass<bool> boolData = new GenericClass<bool>();
            boolData.PrintFunc(true);
        }
    }
}
