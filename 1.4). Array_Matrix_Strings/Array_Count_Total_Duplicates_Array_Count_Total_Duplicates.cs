using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Count_Total_Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int num, count = 0;

            Console.Write("Enter Size of Array : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter elements in Array : ");
            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < num; i++)
            {
                for (int j = i+1 ; j < num; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("\nTotal number of Duplicate Elements are : "+count);
        }
    }
}
