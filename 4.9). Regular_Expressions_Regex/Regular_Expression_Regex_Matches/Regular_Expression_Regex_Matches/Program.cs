using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regular_Expression_Regex_Matches
{
    class Program
    {
        static void Main(string[] args)
        {
            string demo_string = "Sun rises in the East";
            MatchCollection Result;

            Console.WriteLine("Word that starts with 'S' : ");

            // \b is actually the backspace character, not the regex \b
            // \S Matches any non-white-space character.
            // *  Matches the previous element zero or more times

            Result = Regex.Matches(demo_string, @"\bS\S*");

            foreach (Match val in Result)
            {
                Console.WriteLine(val);
            }
        }
    }
}
