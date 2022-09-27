using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUTPUT_4
{
    public class Student
    {
        private static int cnt;
        public Student()
        {
            cnt++;
        }
        public static int Counter
        {
            get
            {
                return cnt;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();

            s1.Counter = 10;

            Console.WriteLine("Total Student is : " +Student.Counter);
        }
    }
}
