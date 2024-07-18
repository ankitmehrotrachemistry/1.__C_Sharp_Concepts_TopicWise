using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Peek_Element
{
    class Program
    {
        static int findPeakElement(int[] arr, int n)
        {
            if (n == 1)
                return 0;
            if (arr[0] >= arr[1])
                return 0;
            if (arr[n - 1] >= arr[n - 2])
                return n - 1;

            for (int i = 1; i < n - 1; i++)
            {
                if (arr[i] >= arr[i - 1] && arr[i] >= arr[i + 1])
                    return i;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int[] arr = {1,4,20,2,1,0};
            int n = arr.Length;

            Console.WriteLine("Index of Peek Point is : " +findPeakElement(arr, n));
        }
    }
}
