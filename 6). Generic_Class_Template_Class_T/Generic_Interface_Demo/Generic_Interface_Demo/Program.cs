using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Interface_Demo
{
    interface Operations<T>
    {
        double Add(T var1, T var2);
        double Sub(T var1, T var2);
    }
    class MyClass<T> : Operations<T>
    {
        public double Add(T var1, T var2)
        {
            double res = Convert.ToDouble(var1) + Convert.ToDouble(var2);
            return res;
        }
        public double Sub(T var1, T var2)
        {
            double res = Convert.ToDouble(var1) - Convert.ToDouble(var2);
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> value1 = new MyClass<int>();
            double value2 = value1.Add(40,48);
            Console.WriteLine("value2 = {0}", value2);

            MyClass<float> valueA = new MyClass<float>();
            double valueB = valueA.Sub(8.8f, 1.6f);
            Console.WriteLine("valueB = {0:f}", valueB);
        }
    }
}
