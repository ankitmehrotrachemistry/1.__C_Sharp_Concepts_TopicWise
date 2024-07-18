using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_With_Class
{
    class MyGenericClass<T>
    {
        private T genericMemVariable;
        public MyGenericClass(T value)
        {
            genericMemVariable = value;
        }

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemVariable);

            return genericMemVariable;
        }

        public T genericProperty { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericClass<int> intGenericValue = new MyGenericClass<int>(100);
            int value = intGenericValue.genericMethod(200);

            MyGenericClass<string> stringGenericValue = new MyGenericClass<string>("Ankit");
            string value1 = stringGenericValue.genericMethod("Generic Parameter");
        }
    }
}
