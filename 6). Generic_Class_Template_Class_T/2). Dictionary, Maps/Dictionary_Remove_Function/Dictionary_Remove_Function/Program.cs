using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Remove_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1,"Ankit");
            dict.Add(2,"Bubbly");
            dict.Add(3,"Chitriz");
            dict.Add(4,"Don");

            Console.WriteLine("Dictionary is :");
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            }

            dict.Remove(3);
            dict.Remove(4);

            Console.WriteLine("Dictionary after removal is :");
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            }
        }
    }
}
