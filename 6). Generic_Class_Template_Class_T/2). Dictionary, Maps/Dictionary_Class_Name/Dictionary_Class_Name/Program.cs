using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Class_Name
{
    class StudentName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<int, StudentName>()
            {
                {001, new StudentName { FirstName = "Ankit", LastName = "Mehrotra", ID = 100} },
                {002, new StudentName { FirstName = "Chaaya", LastName = "Mishra", ID = 400} },
                {003, new StudentName { FirstName = "Binita", LastName = "Kumari", ID = 800} },
                {004, new StudentName { FirstName = "Sippra", LastName = "Tiwari", ID = 1600} }
            };

            foreach (var index in Enumerable.Range(001, 4))
            {
                Console.WriteLine($"Student {index} is {students[index].FirstName} {students[index].LastName}");
            }

            var dict2 = students.Where(x => x.Key <= 2)
                                .Select(x => x);

            foreach (var result in dict2)
            {
                Console.WriteLine(result.Key + " " + result.Value.FirstName);
            }
        }
    }
}
