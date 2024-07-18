using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IList_VS_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //IList<string> i1 = new IList<string>(); // Instance of IList cannot be created

            Console.WriteLine("-------- Ilist Data -------");
            IList<string> i2 = new List<string>();
            i2.Add("Ankit");
            i2.Add("Pulkit");

            foreach (string s in i2)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("-------- List Data -------");
            List<string> i3 = new List<string>();
            i3.Add("Shivani");
            i3.Add("Sakshita");

            foreach (string s in i3)
            {
                Console.WriteLine(s);
            }
        }
    }
}
