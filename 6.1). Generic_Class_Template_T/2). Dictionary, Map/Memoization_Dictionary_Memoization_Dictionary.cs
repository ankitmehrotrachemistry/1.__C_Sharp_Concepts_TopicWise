using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoization_Dictionary
{
    class Program
    {
        static Dictionary<string, string> _lowerCase = new Dictionary<string, string>();

        static string LowerCase1(string value)
        {
            return value.ToLower();
        }

        static string LowerCase2(string value)
        {
            string lookup;

            if (_lowerCase.TryGetValue(value, out lookup))
            {
                return lookup;
            }
            lookup = value.ToLower();

            _lowerCase[value] = lookup;

            return lookup;
        }
        static void Main(string[] args)
        {
            string result1 = LowerCase1("ANKIT");
            string result2 = LowerCase2("MEhRoTrA");
            string result3 = LowerCase2("CompUTeR_ScIEnce");

            Console.WriteLine("{0} , {1} , {2}", result1, result2, result3);
        }
    }
}
