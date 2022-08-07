using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sum_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {12,10,1,4,84};
            int sumOfArray = 0;
            Array.ForEach(array, i => sumOfArray += i);
            Console.WriteLine(sumOfArray);
        }
    }
}
