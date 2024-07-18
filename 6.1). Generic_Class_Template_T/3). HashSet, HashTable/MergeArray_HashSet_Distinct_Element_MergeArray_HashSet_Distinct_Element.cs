using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeArray_HashSet_Distinct_Element
{
    class Program
    {
        static void GetUnion(int[] arr1, int n1, int[] arr2, int n2)
        {
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < n1; i++)
            {
                set.Add(arr1[i]);
            }

            for (int i = 0; i < n2; i++)
            {
                set.Add(arr2[i]);
            }

            Console.WriteLine("Number of Elements after union is : " + set.Count);

            Console.WriteLine("Union of Both Array is : ");
            foreach (int i in set)
                Console.Write(i + " "); // It contains only distinct elements.
        }
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 5, 6, 2, 3, 5, 7, 3 };
            int[] array2 = { 2, 4, 5, 6, 8, 9, 4, 6, 5, 4 };

            GetUnion(array1, 9, array2, 10);
        }
    }
}
