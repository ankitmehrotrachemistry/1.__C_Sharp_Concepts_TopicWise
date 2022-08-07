using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutipleInterfaceDemo
{
    interface IStd1
    {
        void Batch();
    }
    public class Student1
    {
        public void Batch()
        {
            ArrayList list1 = new ArrayList();

            list1.Add("CO-4");
            list1.Add("CO-5");

            Console.WriteLine("\nBatches are :");
            foreach (var b in list1)
            {
                Console.WriteLine(b);
            }
        }
    }
    interface IStd2
    {
        void Grade();
    }
    public class Student2
    {
        public void Grade()
        {
            ArrayList list2 = new ArrayList();

            list2.Add("A");
            list2.Add("B");

            Console.WriteLine("\nGrade is :");
            foreach (var g in list2)
            {
                Console.WriteLine(g);
            }
        }
    }
    public class Student : IStd1, IStd2
    {
        Student1 s1 = new Student1();
        public void Batch()
        {
            s1.Batch();
        }
        Student2 s2 = new Student2();
        public void Grade()
        {
            s2.Grade();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Batch();
            s.Grade();
        }
    }
}
