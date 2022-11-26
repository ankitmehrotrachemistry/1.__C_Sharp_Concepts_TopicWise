using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class EncapsulationClass
    {
        public int data1 { get; }
        protected string data2;
        private float data3;

        public EncapsulationClass()
        {
            data1 = 72;
        }
        public float Data3
        {
            get { return data3; }
            set { data3 = value; }
        }
    }

    class EncapsulationClassInheritance : EncapsulationClass
    {
        public string Data2
        {
            get { return data2; }
            set { data2 = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new EncapsulationClass();

            obj.Data3 = 2.5f;
            Console.WriteLine("Data 3 is : " +obj.Data3);

            var obj2 = new EncapsulationClassInheritance();
            obj2.Data2 = "Test Data";
            Console.WriteLine("Data 2 is : " +obj2.Data2);

            Console.WriteLine("Data 1 is : " +obj.data1);
        }
    }
}
