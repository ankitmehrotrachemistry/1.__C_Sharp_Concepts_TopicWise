using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();

            names.Add("Ankit");
            names.Add("Abhinav");
            names.Add("Ashnav");
            names.Add("Adish");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
