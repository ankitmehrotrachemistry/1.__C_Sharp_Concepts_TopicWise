using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sum_Of_All_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int num, sum = 0;

            Console.WriteLine("Enter the Size of Array : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter elements in Array : ");

            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < num; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum of all Elements of Array is : " +sum);
        }
    }
}
