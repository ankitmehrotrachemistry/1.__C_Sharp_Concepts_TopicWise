using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Select_Distinct_GroupBy
{
    public class LinqTest
    {
        public int id { get; set; }
        public string value { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<LinqTest> myList = new List<LinqTest>();

            myList.Add(new LinqTest() { id = 1, value = "A" });
            myList.Add(new LinqTest() { id = 1, value = "B" });
            myList.Add(new LinqTest() { id = 1, value = "C" });
            myList.Add(new LinqTest() { id = 2, value = "D" });
            myList.Add(new LinqTest() { id = 2, value = "E" });
            myList.Add(new LinqTest() { id = 4, value = "F" });
            myList.Add(new LinqTest() { id = 4, value = "G" });

            var listElem = myList.GroupBy(x => x.id)
                                 .Select(x => x.First());

            foreach (var result in listElem)
            {
                Console.WriteLine(result.id + " " + result.value);
            }
        }
    }
}
