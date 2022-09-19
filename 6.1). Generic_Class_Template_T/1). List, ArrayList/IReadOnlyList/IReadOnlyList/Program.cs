using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IReadOnlyList
{
    class Program
    {
        static readonly List<int> myList = new List<int> {1,2,3,4,5,6,7,8};
        static readonly IReadOnlyList<int> myIReadonlyList = new[] { 1,2,3,4,5,6,7,8};

        static void Main(string[] args)
        {
            myList.Add(10); // Allowed in Normal List

            foreach (var i in myList)
            {
                Console.Write(i + " ");
            }

            // ERROR !!
            //myIReadonlyList.Add(10); // Not Allowed in IReadOnlyList
        }
    }
}
