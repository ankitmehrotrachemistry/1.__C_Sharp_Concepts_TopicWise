using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Method_Payment
{
    abstract class Payment
    {
        public abstract void CalculateFinalMethod();
    }
    class GPay : Payment
    {
        public override void CalculateFinalMethod()
        {
            Console.WriteLine("GPay Payment");
        }
    }
    class PhonePe : Payment
    {
        public override void CalculateFinalMethod()
        {
            Console.WriteLine("PhonePe Payment");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GPay g = new GPay();
            g.CalculateFinalMethod();
            PhonePe p = new PhonePe();
            p.CalculateFinalMethod();
        }
    }
}
