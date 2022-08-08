using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class_Type_T
{
    public class GenericClass<T>
    {
        public T Message;
        public void GenericMethod(T name, T location)
        {
            Console.WriteLine($"Message : {Message}");
            Console.WriteLine($"Name : {name}" );
            Console.WriteLine($"Location : {location}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> myGenericString = new GenericClass<string>();
            myGenericString.Message = "Welcome Back!!";
            myGenericString.GenericMethod("Ankit", "Mehrotra");

            GenericClass<int> myGenericInt = new GenericClass<int>();
            myGenericInt.Message = 12;
            myGenericInt.GenericMethod(100, 200);
        }
    }
}
