using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Negative_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int num;

            Console.WriteLine("Enter the size of Array: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Elements in Array :");
            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("All Negative Elements in Array are : ");
            for (int i = 0; i < num; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
