using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToByteDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = { 'a', 'r', 'd' , 'v' , 'p'};

            foreach (char ch in charArray)
            {
                byte byteValue = Convert.ToByte(ch);
                Console.WriteLine("{0} is converted to {1}", ch, byteValue);
            }
            Console.WriteLine("============================");

            int[] intArray = { 20, 40, 60, 80, 200};

            foreach (int i in intArray)
            {
                byte byteValue = Convert.ToByte(i);
                Console.WriteLine("{0} is converted to {1}", i, byteValue);
            }
            Console.WriteLine("============================");

            float[] floatArray = { 2.4f, 4.4f, 8.4f, 16.8f};

            foreach(float f in floatArray)
            {
                byte floatValue = Convert.ToByte(f);
                Console.WriteLine("{0} is converted to {1}", f, floatValue);
            }
        }
    }
}
