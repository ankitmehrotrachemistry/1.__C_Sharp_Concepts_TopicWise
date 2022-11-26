using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorValueAssign
{
    class Program
    {
        private string month;
        private int year;

        public Program(Program P)
        {
            month = P.month;
            year = P.year;
        }

        public Program(string month, int year)
        {
            this.month = month;
            this.year = year;
        }
        public string Details
        {
            get
            {
                return "Month is : " + month.ToString() + " and Year is : " + year.ToString();
            }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program("April", 2022);
            Program p2 = new Program(p1);

            Console.WriteLine(p2.Details);
        }
    }
}
