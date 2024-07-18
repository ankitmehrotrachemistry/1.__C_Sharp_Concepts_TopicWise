using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aristo_Delegate_Printer
{
    class Program
    {
        delegate void Printer();
        static void Main(string[] args)
        {
            List<Printer> printers = new List<Printer>();

            int i = 0;
            for(; i < 10; i++)
            {
                printers.Add(delegate { Console.WriteLine(i); });
            }

            foreach(var printer in printers)
            {
                printer();
            }
        }
    }
}
