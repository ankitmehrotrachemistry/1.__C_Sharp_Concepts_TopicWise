using System;

namespace Aristo_Int_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2020;
            object obj = num;
            num = 100;

            Console.WriteLine("Value - type value of num is " + num + " and type is : " + num.GetType());
            Console.WriteLine("Object - type value of num is " + obj + " and type is : " + obj.GetType());
        }
    }
}
