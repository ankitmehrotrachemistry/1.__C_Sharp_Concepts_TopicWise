using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_AddElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- Dictionary Elements ------------------");

            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1,"Ankit");
            dict.Add(4,"Rohan");
            dict.Add(2,"Priti");
            dict.Add(3,null);

            dict[5] = "Pradeep";

            try
            {
                dict.Add(4,"Satish");
            }
            catch
            {
                Console.WriteLine("Element with Key = '4' already exists");
            }

            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            }

            Console.WriteLine("--------------- Dictionary2 Element ------------------");

            Dictionary<string, int?> dict2 = new Dictionary<string, int?> {
                                                  {"Msg2", 1},
                                                  {"Msg3", 10},
                                                  {"Msg4", 100},
                                                  {"Msg1", null}
                                              };
            foreach (KeyValuePair<string, int?> item in dict2)
            {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            }
            Console.ReadLine();
        }
    }
}
