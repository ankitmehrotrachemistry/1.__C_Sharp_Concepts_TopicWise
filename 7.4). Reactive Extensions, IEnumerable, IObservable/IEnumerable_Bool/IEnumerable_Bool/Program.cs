using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_Bool
{
    class Program
    {
        static void Display(IEnumerable<bool> argument)
        {
            foreach (bool val in argument)
            {
                Console.WriteLine(val);
            }
        }
        static void Main(string[] args)
        {
            Display(new List<bool> { true, false, true, false});
        }
    }
}
