using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Select_Distinct_List
{
    public class LinqTest
    {
        public int id { get; set; }
        public string value { get; set; }
        public override bool Equals(object obj)
        {
            LinqTest obj2 = obj as LinqTest;
            if (obj2 == null) return false;
            return id == obj2.id;
        }

        public override int GetHashCode()
        {
            return id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<LinqTest> myList = new List<LinqTest>();

            myList.Add(new LinqTest() { id = 1, value = "A"});
            myList.Add(new LinqTest() { id = 1, value = "B" });
            myList.Add(new LinqTest() { id = 2, value = "C" });
            myList.Add(new LinqTest() { id = 4, value = "D" });
            myList.Add(new LinqTest() { id = 4, value = "E" });
            myList.Add(new LinqTest() { id = 5, value = "E" });

            var result = myList.GroupBy(x => x.id)
                               .Select(x => x.First())
                               .ToList();

            foreach (var p in result)
            {
                Console.WriteLine(p.id + "\t" + p.value);
            }

            Console.WriteLine("=========== DIFFERENT METHOD ============");
            
            List<LinqTest> uniqueID = myList.Distinct().ToList();

            foreach (var p1 in uniqueID)
            {
                Console.WriteLine(p1.id + "\t" + p1.value);
            }
        }
    }
}