using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_EndsWith_Selective_Removal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                {1, "Ankit Kumar"},
                {2, "Shiva Thappar"},
                {3, "Sakshi Singh"},
                {4, "Ankur Kumar"}
            };
            Console.WriteLine("Dictionary Key and Value");
            foreach (KeyValuePair<int, string> name in names)
            {
                Console.WriteLine(name.Key + "->" + name.Value);
            }
            int[] keysToDelete = names.Where(x => x.Value.EndsWith("Kumar")).Select(x => x.Key).ToArray();

            Console.WriteLine("\nRemove Particular Elements from Dictionary");

            foreach (int key in keysToDelete)
            {
                names.Remove(key);
                Console.WriteLine("Key ["+ key +"] removed from Dictionary");
            }

            Console.WriteLine("Dictionary Keys and Value after removal");

            foreach (KeyValuePair<int, string> name in names)
            {
                Console.WriteLine(name.Key + "->" +name.Value);
            }
        }
    }
}
