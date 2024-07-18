using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_T_ShowArray
{
    public class Example
    {
        public static void ShowArray<T>(T[] arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static bool Check<T>(T a, T b)
        {
            bool c = a.Equals(b);
            return c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[4] {2,4,6,7};

            string[] Names = {"Ankit", "Baby", "Chitra", "David"};

            Example.ShowArray(Numbers);
            Example.ShowArray(Names);

            Console.WriteLine(Example.Check(100, 200));
            Console.WriteLine(Example.Check("Ankit", "Ankita"));
        }
    }
}