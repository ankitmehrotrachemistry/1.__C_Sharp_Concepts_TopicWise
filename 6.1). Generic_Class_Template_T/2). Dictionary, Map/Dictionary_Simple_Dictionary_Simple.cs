using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> My_Dictionary = new Dictionary<int, string>();

            My_Dictionary.Add(1,"Ankit");
            My_Dictionary.Add(2, "Barbie");
            My_Dictionary.Add(3, "Chaatri");
            My_Dictionary.Add(4, "David");

            foreach(KeyValuePair<int, string> kvp in My_Dictionary)
            {
                Console.WriteLine("Key : {0} , Value : {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
