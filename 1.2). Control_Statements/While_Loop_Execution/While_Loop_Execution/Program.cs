using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_Execution
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.Write("Enter the value of a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            while(i <= a)
            {
                Console.WriteLine("CSharpUnityDev");
                i++;
            }
        }
    }
}
