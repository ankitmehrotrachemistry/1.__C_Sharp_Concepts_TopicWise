using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Param_Keyword_Method
{
    class Program
    {
        public static void PrintMyList(params string[] listToPrint)
        {
            foreach (var item in listToPrint)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            string firstLine = "My Name is Ankit Mehrotra";
            string secondLine = "I am Computer Engineer";
            string thirdLine = "My College was N.I.T. Kurukshetra";
            string fourthLine = "I am Game Developer by Profession";

            PrintMyList(firstLine, secondLine, thirdLine, fourthLine);
        }
    }
}
