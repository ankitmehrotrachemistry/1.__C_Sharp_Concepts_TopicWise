using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> i = null;
            if (i.HasValue)
                Console.WriteLine(i.Value);
            else
                Console.WriteLine("Null");
        }
    }
}
