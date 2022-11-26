using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Remove_Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 5, 6, 2, 2, 5 };
            int size = arr.Length;
            for(int i = 0; i < size; i++)
            {
                for(int j = i+1; j < size; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        for(int k = j; k < size - 1; k++)
                        {
                            arr[k] = arr[k + 1];
                        }
                        size--;
                        j--;
                    }
                }
            }
            Console.WriteLine("Elements after deletion of duplicate");
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
