using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Tuple<string, string>, string> dict = new Dictionary<Tuple<string, string>, string>();

            Tuple<string, string> dict1 = Tuple.Create("A1","A");
            Tuple<string, string> dict2 = Tuple.Create("A2", "A");
            Tuple<string, string> dict3 = Tuple.Create("A3", "A");
            Tuple<string, string> dict4 = Tuple.Create("A2", "A");

            dict.Add(dict1, "B1");
            dict.Add(dict2, "B2");
            dict.Add(dict3, "B3");

            if (dict.ContainsKey(dict4))
            {
                Console.WriteLine("Yes");
                Console.WriteLine(dict[dict2]);
            }
            else 
            {
                Console.WriteLine("No");
            }
        }
    }
}