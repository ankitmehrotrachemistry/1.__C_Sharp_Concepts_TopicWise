using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int_Double_Typecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double doubleVal = 1234.78;
            int intValue = (int)doubleVal;
            Console.WriteLine("Value after typecasting is : " + intValue);
        }
    }
}
