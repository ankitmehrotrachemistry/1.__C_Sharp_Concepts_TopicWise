using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Combine_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            dict1.Add("A01", 1);
            dict1.Add("B01", 2);
            dict1.Add("C01", 3);
            dict1.Add("D01", 4);
            dict1.Add("E01", 5);

            Dictionary<string, int> dict2 = new Dictionary<string, int>();
            dict2.Add("F01", 6);
            dict2.Add("G01", 7);
            dict2.Add("H01", 8);
            dict2.Add("I01", 9);

            HashSet<string> hash = new HashSet<string>(dict1.Keys);
            hash.UnionWith(dict2.Keys);

            foreach (string res in hash)
            {
                Console.WriteLine(res);
            }

        }
    }
}
