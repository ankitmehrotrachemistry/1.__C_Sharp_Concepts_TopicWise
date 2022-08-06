using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Param_Object_Type
{
    class Program
    {
        public void Result(params object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void Main(string[] args)
        {
            Program prog = new Program();

            // Object type Params will allow any type of
            // arguments and any number of arguments 

            prog.Result("Ankit", "ANKIT", "4345", "12.88F");
        }
    }
}
