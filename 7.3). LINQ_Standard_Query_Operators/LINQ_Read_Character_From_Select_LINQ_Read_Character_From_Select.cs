using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Read_Character_From_Select
{
    class Program
    {
        static void Main(string[] args)
        {
            string Email = "ankit";

            var characters = from c in Email
                             select c;
            Console.WriteLine("Characters are : ");

            foreach (char c in characters)
            {
                Console.WriteLine(" " + c + "\n");
            }
        }
    }
}
