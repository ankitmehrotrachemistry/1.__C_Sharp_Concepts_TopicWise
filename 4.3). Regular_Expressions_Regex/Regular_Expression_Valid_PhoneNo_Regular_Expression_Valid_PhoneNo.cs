using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regular_Expression_Valid_PhoneNo
{
    class Program
    {
        public static bool isValidMobileNumber(string inputMobileNumber)
        {
            string strRegex = @"( ^[0-9]{10}$ ) |
                                ( ^\+[0-9]{2}\s +[0-9]{2}[0-9]{8}$ ) |
                                ( ^[0-9]{3}-[0-9]{4}-[0-9]{4}$ )";

            Regex re = new Regex(strRegex);

            if (re.IsMatch(inputMobileNumber))
                return (true);
            else
                return (false);
             
        }
        static void Main(string[] args)
        {
            string[] str = { "9925612824", "8238783138", "02812451830" };

            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} valid mobile number", s, isValidMobileNumber(s) ? "is" : "is not");
            }
        }
    }
}
