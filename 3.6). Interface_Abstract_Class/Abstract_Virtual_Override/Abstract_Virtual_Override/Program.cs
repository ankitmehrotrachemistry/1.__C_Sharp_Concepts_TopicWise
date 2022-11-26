using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Virtual_Override
{
    abstract class Car
    {
        public virtual string CarDetails()
        {
            return "Car Description";
        }
    }
    class Lamborghini : Car
    {
        public override string CarDetails()
        {
            return "Lamborghini Car";
        }
    }
    class Program
    {
        void Print(int i, int j)
        {
            Console.WriteLine("Print Integer : {0}", (i+j));
        }
        void Print(string a, string b)
        {
            Console.WriteLine("Print String : " + a+b);
        }
        static void Main(string[] args)
        {
            Program prog = new Program();

            prog.Print(24,48);
            prog.Print("Ankit", "Mehrotra");

            Lamborghini lbn = new Lamborghini();
            String desc = lbn.CarDetails();

            Car car = new Lamborghini();
            String desc1 = car.CarDetails();

            Console.WriteLine(desc);
            Console.WriteLine(desc1);

        }
    }
}
