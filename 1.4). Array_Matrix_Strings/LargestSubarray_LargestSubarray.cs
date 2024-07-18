using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestSubarray
{
    class LargestSubArrayProgram
    {
        static int findSubArray(int[] arr, int n)
        {
            int sum = 0;
            int maxsize = -1, startindex = 0;
            int endindex = 0;

            // Pick a starting point as i 
            for (int i = 0; i < n - 1; i++)
            {
                sum = (arr[i] == 0) ? -1 : 1;

                // Consider all subarrays starting from i 

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] == 0)
                        sum += -1;
                    else
                        sum += 1;

                    // If this is a 0 sum subarray, then  
                    // compare it with maximum size subarray 
                    // calculated so far 

                    if (sum == 0 && maxsize < j - i + 1)
                    {
                        maxsize = j - i + 1;
                        startindex = i;
                    }
                }
            }
            endindex = startindex + maxsize - 1;
            if (maxsize == -1)
                Console.WriteLine("No such subarray");
            else
                Console.WriteLine(startindex + " to " + endindex);

            return maxsize;
        }

        static void Main(string[] args)
        {

            int[] arr = { 1, 0, 0, 1, 0, 1, 1 };
            int size = arr.Length;
            findSubArray(arr, size);
        }
    }
}
