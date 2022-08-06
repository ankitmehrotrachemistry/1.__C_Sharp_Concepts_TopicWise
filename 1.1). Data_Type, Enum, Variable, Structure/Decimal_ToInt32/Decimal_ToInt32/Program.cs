using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_ToInt32
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Decimal dec1 = 542635748M;
                Decimal dec2 = 432443278.45m;

                int val1 = Decimal.ToInt32(dec1);
                int val2 = Decimal.ToInt32(dec2);

                Console.WriteLine("Val1 Int32 value {0}", val1);
                Console.WriteLine("Val2 Int32 value {0}", val2);
            }
            catch (OverflowException e)
            {
                Console.Write("Exception Thrown");
                Console.Write("{0}", e.GetType(), e.Message);
            }
        }
    }
}
