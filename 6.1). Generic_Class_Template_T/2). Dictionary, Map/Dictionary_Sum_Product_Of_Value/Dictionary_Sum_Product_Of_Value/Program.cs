using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Sum_Product_Of_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, mult = 1;

            Dictionary<string, int> dict = new Dictionary<string, int>();

            dict.Add("val1", 10);
            dict.Add("val2", 40);
            dict.Add("val3", 8);
            dict.Add("val4", 80);
            dict.Add("val5", 64);

            foreach (var d in dict)
            {
                Console.WriteLine("Key : {0}, Value : {1}", d.Key, d.Value);
            }

            foreach (var item in dict)
            {
                sum += item.Value;
            }
            Console.WriteLine("Sum of Value in Dictionary is" +sum);

            foreach (var item in dict)
            {
                mult *= item.Value;
            }
            Console.WriteLine("Multiplication of Value in Dictionary is "+mult);
        }
    }
}
