using System;

namespace LargestElementInArray
{
    class Program
    {
        static int[] arr = {10,20,40,5,2};

        static int LargestElement()
        {
            int i;
            int max = arr[0];

            for (i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Largest Element is : " + LargestElement());
        }
    }
}
