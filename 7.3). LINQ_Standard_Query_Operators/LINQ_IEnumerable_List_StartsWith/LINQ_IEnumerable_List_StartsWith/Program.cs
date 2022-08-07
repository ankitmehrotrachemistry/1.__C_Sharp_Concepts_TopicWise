using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_IEnumerable_List_StartsWith
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();

            myList.Add("Saurabh");
            myList.Add("Ankit");
            myList.Add("Sachin");
            myList.Add("Ashwini");

            IEnumerable names = from x in myList where (x.StartsWith("S")) select x;

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
