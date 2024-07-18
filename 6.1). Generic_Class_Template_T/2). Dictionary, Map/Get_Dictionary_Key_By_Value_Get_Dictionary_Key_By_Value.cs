using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Dictionary_Key_By_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> types = new Dictionary<string, string>()
            {
                {"1", "One"},
                {"2", "Two"},
                {"3", "Three"},
                {"4", "Four"}
            };
            string key = " ";

            foreach (var pair in types)
            {
                if (pair.Value == "One")
                {
                    key = pair.Key;
                }
            }
            Console.WriteLine("Using ForEach Loop Key for One is : " +key);

            var myKey = types.FirstOrDefault(x => x.Value == "Four").Key;

            Console.WriteLine("Using LINQ Key for Four is : " +myKey);
        }
    }
}
