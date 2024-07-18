using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Class_Enumerable_Range
{
    class Program
    {
        class StudentName
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int ID { get; set; }
        }
        static void Main(string[] args)
        {
            var Students = new Dictionary<int, StudentName>()
            {
                { 
                    111, new StudentName {FirstName = "Sachin", LastName = "Tichkule", ID = 001} 
                },
                {
                    112, new StudentName { FirstName = "Ankit", LastName = "Mehrotra", ID = 002}
                },
                {
                    113, new StudentName {FirstName = "Rajpal", LastName = "Rangeela", ID = 003}
                },
                {
                    114, new StudentName { FirstName = "Dina", LastName = "Kojrawov", ID = 004}
                },
            };
            foreach (var index in Enumerable.Range(111, 4))
            {
                Console.WriteLine($"Student {index} is {Students[index].FirstName} {Students[index].LastName} ");
            }
        }
    }
}
