using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Delegate_Method
{
    public class Program
    {
        public static void Printvalue(int i)
        {
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            Action<int> ActionDel = Printvalue;
            ActionDel(100);
        }
    }
}
