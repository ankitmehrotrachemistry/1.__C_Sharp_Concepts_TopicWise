using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListShuffle_LINQ
{
    public class Student
    {
        string name;
        public Student(string name)
        {
            Name = name; 
        }
        public string Name { get => name; set => name = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> myList = new List<Student>();

            myList.Add(new Student("Ankit"));
            myList.Add(new Student("Anil"));
            myList.Add(new Student("Pravin"));
            myList.Add(new Student("Bobby"));
            myList.Add(new Student("Drikhsa"));

            var rand = new Random();
            var result = myList.OrderBy(item => rand.Next());

            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
