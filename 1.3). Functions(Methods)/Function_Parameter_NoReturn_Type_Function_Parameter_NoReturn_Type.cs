using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Parameter_NoReturn_Type
{
    class Program
    {
        public void Show(string name)
        {
            Console.WriteLine("Hello " +name);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Show("Ankit");
        }
    }
}
