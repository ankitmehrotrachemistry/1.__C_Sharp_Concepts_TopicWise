using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex_Valid_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternText = @"^[a-zA-Z0-9\._-]{5,25}.@.[a-z]{2,12}.(com|org|co\.in|net)";
            Regex reg = new Regex(patternText);
            Console.WriteLine(reg.IsMatch("ankit_mehrotra1234@gmail.com"));
            Console.WriteLine(reg.IsMatch("www.trewtetewy@google.com"));
            Console.WriteLine(reg.IsMatch("www.alaksa.123@gmail.co"));
            Console.WriteLine(reg.IsMatch("software_test1234@movie.dont"));
        }
    }
}