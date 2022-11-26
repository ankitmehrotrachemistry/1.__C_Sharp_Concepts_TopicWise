using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disarium_Number
{
    // A number will be called Disarium if the sum of its digits powered with their respective position is equal to the number itself.
    // 175 => 1^[1] + 7^[2] + 5^[3] = 1 + 49 + 125 = 175 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a Number");

            int number = Convert.ToInt32(Console.ReadLine());
            string numString = number.ToString();
            int length = numString.Length;

            int divide = 0, sum = 0, copy = number;

            while (copy > 0)
            {
                divide = copy % 10;
                sum = sum + (int)Math.Pow(divide, length);
                length--;
                copy = copy / 10;
            }
            if (sum == number)
            {
                Console.WriteLine("Disarium Number");
            }
            else
            {
                Console.WriteLine("Not a Disarium Number");
            }
        }
    }
}
