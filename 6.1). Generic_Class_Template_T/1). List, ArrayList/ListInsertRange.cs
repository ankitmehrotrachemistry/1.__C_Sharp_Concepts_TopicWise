using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInsertRange
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<string>() {"Cat", "Dog"};

            animals.InsertRange(2, new string[] {"Elephant","Zebra", "Lion", "Tiger"});

            foreach (string value in animals)
            {
                Console.WriteLine("List of Animals are:" +value);
            }
        }
    }
}
