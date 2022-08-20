using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex_Valid_Website
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternText = @"^www.[a-zA-Z0-9]{3,20}.(com|in|org|co\.in|net|dev)$";

            Regex reg = new Regex(patternText);

            Console.WriteLine(reg.IsMatch("www.google.com"));
            Console.WriteLine(reg.IsMatch("http.facebook.com"));
            Console.WriteLine(reg.IsMatch("ww.yahoo.com"));
            Console.WriteLine(reg.IsMatch("www.springer.org"));
            Console.WriteLine(reg.IsMatch("WWW.internetexplorer.in"));
        }
    }
}
