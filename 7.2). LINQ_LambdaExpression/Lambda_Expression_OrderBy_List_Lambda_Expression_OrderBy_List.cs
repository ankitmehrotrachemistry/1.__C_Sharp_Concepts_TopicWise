using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_OrderBy_List
{
    class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> details = new List<Student>()
            {
                new Student { RollNumber = 12, Name = "Chaaya"},
                new Student { RollNumber = 24, Name = "Shipra"},
                new Student { RollNumber = 36, Name = "Arpita"},
                new Student { RollNumber = 48, Name = "Ankita"},
                new Student { RollNumber = 60, Name = "Boby"},
            };

            var newDetails = details.OrderBy(x=>x.Name);

            foreach (var value in newDetails)
            {
                Console.WriteLine(value.RollNumber + " " + value.Name);
            }

            //List<int> divBy3 = details.FindAll(x => (x.RollNumber % 3 == 0));

        }
    }
}
