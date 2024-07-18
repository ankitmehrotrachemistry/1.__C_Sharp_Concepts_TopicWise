using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_List_IEnumerable
{
    class Program
    {
        public static IEnumerable<string> GetMyList()
        {
            List<string> my_List = new List<string>() {"Cat", "Dog", "Parrot", "Crow"};

            foreach (var items in my_List)
            {
                yield return items;
            }
        }
        static void Main(string[] args)
        {
            IEnumerable<string> list_Items = GetMyList();

            foreach (var i in list_Items)
            {
                Console.WriteLine(i);
            }
        }
    }
}
