using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;

namespace Immutable_List_Demo
{
    // Import Immutable Library and NewtonSoft Json Library
    class Program
    {
        static readonly ImmutableList<int> numberList = new List<int> { 1, 2, 3, 4, 5 }.ToImmutableList();
        static void Main(string[] args)
        {
            //numberList[0] = 4;

            numberList.Add(12);
            numberList.Remove(2);
        }
    }
}
