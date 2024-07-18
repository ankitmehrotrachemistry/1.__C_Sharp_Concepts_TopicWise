using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(7);

            Console.WriteLine("LIST 1: " + numbers.Count);

            // Version 2: create a List with an initializer.

            var numbers2 = new List<int>() { 2, 3, 5, 7, 1 };

            numbers2.Add(8);

            Console.WriteLine("LIST 2: " + numbers2.Count);
        }
    }
}
