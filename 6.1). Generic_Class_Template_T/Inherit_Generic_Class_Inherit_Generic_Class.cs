using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit_Generic_Class
{
    class Base_Class<T>
    {
        T baseObj;
        public Base_Class(T _baseObj)
        {
            baseObj = _baseObj;
        }
        public T Value
        {
            get { return baseObj; }
            set { baseObj = value; }
        }
    }
    class Derived_Class<T> : Base_Class<T>
    {
        T derivedObj;
        public Derived_Class(T _baseObj, T _derivedObj) : base(_baseObj)
        {
            derivedObj = _derivedObj;
        }
        public new T Value
        {
            get { return derivedObj; }
            set { derivedObj = Value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Derived_Class<int> der1 = new Derived_Class<int>(4,8);

            Console.WriteLine("Derived Class Value = {0}", der1.Value);

        }
    }
}
