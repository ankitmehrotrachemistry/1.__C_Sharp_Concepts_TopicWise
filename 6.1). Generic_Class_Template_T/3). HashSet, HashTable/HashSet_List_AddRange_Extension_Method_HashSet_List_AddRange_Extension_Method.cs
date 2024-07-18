using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_List_AddRange_Extension_Method
{
    public static class Extensions
    {
        public static void AddRange<T>(this HashSet<T> hashset, IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                hashset.Add(item);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4 };
            HashSet<int> hashSet = new HashSet<int>() { 2, 4, 5, 6 };

            hashSet.AddRange(list);

            // HashSet does not permit duplicates.
            // HashSet maintains no particular order of it's elements.

            Console.WriteLine(String.Join(", ", hashSet));
        }
    }
}
