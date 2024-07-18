using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArray
{
    class Program
    {
        public static void reverse(int[] arr, int n, int k)
        {
            for (int i = 0; i < n; i += k)
            {
                int left = i;

                int right = Math.Min(i + k - 1, n - 1);
                int temp;

                while (left < right)
                {
                    temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left += 1;
                    right -= 1;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] {1,2,3,4,5,6,7,8};

            int k = 6;

            int n = arr.Length;

            reverse(arr, n, k);

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
