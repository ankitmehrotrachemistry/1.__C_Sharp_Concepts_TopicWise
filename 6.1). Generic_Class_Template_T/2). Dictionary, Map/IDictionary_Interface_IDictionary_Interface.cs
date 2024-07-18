using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDictionary_Interface
{
    class Program
    {
        static void Display(IDictionary<string, string> dict)
        {
            Console.WriteLine(dict["Subject"]);
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> Student = new Dictionary<string, string>();

            Student["Subject"] = "C#";
            Display(Student);

            Student["Subject"] = "JAVA";
            Display(Student);
        }
    }
}
