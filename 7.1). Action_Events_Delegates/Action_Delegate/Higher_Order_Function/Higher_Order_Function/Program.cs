using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://jeremybytes.blogspot.com/2014/06/recognizing-higher-order-function-in-c.html

namespace Higher_Order_Function
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return string.Format("{0}{1}", FirstName, LastName);
        }
        public string ToString(Func<Person, string> format)
        {
            if (format != null)
                return format(this);
            return this.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> personList = new List<string> {"fsd", "rger"};

            var person = personList.ElementAt(0) as Person;


        }
    }
}
