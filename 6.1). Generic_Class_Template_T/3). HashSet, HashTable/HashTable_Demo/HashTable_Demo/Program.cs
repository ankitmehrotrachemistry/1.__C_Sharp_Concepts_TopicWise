using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable nums = new Hashtable();
            nums.Add(1,"One");
            nums.Add(2,"Two");
            nums.Add(3,"Three");
            nums.Add(4,"Four");
            // Elements are stored as DictionaryEntry objects.
            foreach (DictionaryEntry kvp in nums)
                Console.WriteLine("Key : {0}, Value : {1}", kvp.Key, kvp.Value);
            // Create Hashtable using collection-initializer syntax
            var names = new Hashtable() {
                {"A", "Ankit, Archit"},
                {"B", "Baby, Basin"},
                {"C", "Chimis, Chitra"},
                {"D", "Duster, Darry"}
            };
            foreach (DictionaryEntry kvp in names)
                Console.WriteLine("Key : {0}, Value : {1}", kvp.Key, kvp.Value);
        }
    }
}
