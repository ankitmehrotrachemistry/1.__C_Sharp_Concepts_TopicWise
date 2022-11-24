using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDictionary_int_str_Dictionary_str_str
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> numberName = new Dictionary<int, string>();
            Console.WriteLine("----- IDictionary int and String----- ");
            numberName.Add(1, "One");
            numberName.Add(2, "Two");
            numberName.Add(3, "Three");
            numberName.Add(4, "Four");
            foreach (KeyValuePair<int, string> kvp in numberName)
                Console.WriteLine("Key is {0}, Value is {1}", kvp.Key, kvp.Value);

            Console.WriteLine("----- Dictionary string and string -----");
            var games = new Dictionary<string, string>() { 
                            {"FPS", "Call of Duty, CS GO" },
                            {"Platformer", "Dave, Mario"}
                          };
            foreach (var kvp in games)
                Console.WriteLine("Key : {0}, Value : {1}", kvp.Key, kvp.Value);
        }
    }
}
