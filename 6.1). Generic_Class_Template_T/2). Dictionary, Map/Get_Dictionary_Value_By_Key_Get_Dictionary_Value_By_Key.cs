using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Dictionary_Value_By_Key
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary =
                new Dictionary<int, string>();

            myDictionary.Add(1, "Value 1");
            myDictionary.Add(2, "Value 2");
            myDictionary.Add(3, "Value 3");
            myDictionary.Add(4, "Value 4");

            Console.WriteLine("Value for Key 1 using [] Method is : " + myDictionary[1]);

            string value;
            bool hasValue = myDictionary.TryGetValue(4, out value);

            if (hasValue)
            {
                Console.WriteLine("Value for Key 4 using TryGetValue is : " + value);
            }
            else
            {
                Console.WriteLine("Key Not Present");
            }
        }
    }
}
