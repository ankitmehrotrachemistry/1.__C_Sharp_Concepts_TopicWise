using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Using_Get_Set
{
    public class NumberTest
    {
        private int nNum = 0;
        public int Num
        {
            get 
               {
                  return nNum;  
               }
            set 
               {
                if (value % 2 == 0)
                {
                    Console.WriteLine("Even Number");
                }
                else
                {
                    Console.WriteLine("Odd Number");
                }
               }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NumberTest numTest = new NumberTest();
            Console.WriteLine("Enter the Number");
            numTest.Num = Convert.ToInt32(Console.ReadLine() );
        }
    }
}
