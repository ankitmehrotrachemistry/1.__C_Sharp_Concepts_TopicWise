using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Type_Basic_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new { Id = 1, FirstName = "Ankit", LastName = "Mehrotra"};

            Console.WriteLine(student.Id);
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);

        }
    }
}
