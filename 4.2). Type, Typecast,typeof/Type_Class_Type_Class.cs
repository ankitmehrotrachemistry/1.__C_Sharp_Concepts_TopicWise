using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Class
{
    class Program
    {
        static void Test(Type type)
        {
            Console.WriteLine("IsArray : {0}", type.IsArray);
            Console.WriteLine("Name : {0}", type.Name);
        }
        static void Main(string[] args)
        {
            Type type1 = typeof(string[]);
            Type type2 = "string".GetType();

            Test(type1);
            Test(type2);
        }
    }
}
