using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge3Array
{
    class Merge3Arrays
    {
        static void Merge2(int[] arr1, int len1, int[] arr2)
        {
            int i = len1 - 1;
            int j = arr2.Length - 1;
            int k = len1 + arr2.Length - 1;

            while (i >= 0 && j >= 0)
            {
                if (arr1[i] >= arr2[j])
                {
                    arr1[k--] = arr1[i--];
                }
                else
                {
                    arr1[k--] = arr2[j--];
                }
            }

            while (j >= 0)
            {
                arr1[k--] = arr2[j--];
            }
        }

        static void Merge3(int[] arr1, int[] arr2, int[] arr3, int[] output)
        {
            arr1.CopyTo(output, 0);
            Merge2(output, arr1.Length, arr2);
            Merge2(output, arr1.Length + arr2.Length, arr3);
        }

        static void PrintArray(int[] arr, string msg)
        {
            Console.WriteLine(msg);
            foreach (var i in arr)
            {
                Console.Write("{0, 4}", i);
            }
            Console.WriteLine();
        }

        static void DoTest(int[] arr1, int[] arr2, int[] arr3, int[] output)
        {
            PrintArray(arr1, "A");
            PrintArray(arr2, "B");
            PrintArray(arr3, "C");
            Merge3(arr1, arr2, arr3, output);
            PrintArray(output, "D after merging");
        }

        static void Main(string[] args)
        {
            int[] A = { 2, 4, 6, 8 };
            int[] B = { 1, 3, 5, 7 };
            int[] C = { 10, 12, 14, 16 };
            int[] D = new int[A.Length + B.Length + C.Length];
            DoTest(A, B, C, D);
        }
    }
}
