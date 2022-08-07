using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Reversal
{
    class Program
    {
        public static void ReverseArray(int[] arr, int start, int end)
        {
            int temp;

            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
        public static void PrintArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5,6,7,8};

            Console.WriteLine("Original Array is : ");
            PrintArray(array, 8);

            ReverseArray(array, 0, 7);

            Console.Write("Reversed Array is : \n");
            PrintArray(array, 8);
        }
    }
}
