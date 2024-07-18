using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Elements_Of_Array_To_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int[] first = new int[100];
            int[] second = new int[100];

            int num;

            Console.WriteLine("Enter size of array : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Elements in Array :");
            for (int i = 0; i < num; i++)
            {
                first[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < num; i++)
            {
                second[i] = first[i];
            }

            Console.WriteLine("Elements of First Array are : ");
            for (int i = 0; i < num; i++)
            {
                Console.Write(first[i] + "\t");
            }

            Console.WriteLine("\nElements of Second Array are : ");
            for (int i = 0; i < num; i++)
            {
                Console.Write(second[i] +"\t");
            }
        }
    }
}
