using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class DefaultConstructor
    {
        public DefaultConstructor()
        {
            Console.WriteLine("First Constructor - Default");
        }
    }
    class ParameterizedConstructor
    {
        public ParameterizedConstructor()
        {
            Console.WriteLine("Second Constructor - Non-Parameterized");
        }

        public ParameterizedConstructor(int i)
        {
            Console.WriteLine("Third Constructor - Parameterized Constructor");
        }
    }
    class CopyConstructor
    {
        private string _data;
        private int _number;

        public CopyConstructor(CopyConstructor obj)
        {
            _data = obj._data;
            _number = obj._number;
        }

        public CopyConstructor(string data, int number)
        {
            _data = data;
            _number = number;
        }

        public void DataWriter()
        {
            Console.WriteLine("Data is : " + _data + " Number is :" +_number);
        }
    }
    class PrivateConstructor
    {
        private PrivateConstructor()
        {

        }
        public void Method()
        {
            Console.WriteLine("Method is running");
        }
        public static void StaticMethod()
        {
            Console.WriteLine("Static Method is running");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Default Constructor\n-----------------------\n");
            var obj1 = new DefaultConstructor();
            
            //Parameterized Constructor

            Console.WriteLine("\nParameterized Constructor\n-----------------------\n");
            var obj2 = new ParameterizedConstructor();
            obj2 = new ParameterizedConstructor(5);
            
            //Copy Constructor

            Console.WriteLine("\nCopy Constructor\n-----------------------\n");
            var obj3 = new CopyConstructor("My Data", 1);
            obj3 = new CopyConstructor(obj3);
            obj3.DataWriter();
            
            //Private Constructor

            Console.WriteLine("\nPrivate Constructor\n-----------------------\n");
            //var obj4=new PrivateConstructors(); - this command line is illegal
            //PrivateConstructors method is private so this can't access to PrivateConstructors
            //In this class or another class, only can access static class or another 
            //public constructor in which called class
        }
    }
}
