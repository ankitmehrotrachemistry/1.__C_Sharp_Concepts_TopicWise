using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_MyAddress
{
    struct Address
    {
        public string Name;
        public string City;
        public string State;
        public int Pin;
    };
    class Program
    {
        static void Main(string[] args)
        {
            Address address1;
            Address address2;
            address1.Name = "Main Road";
            address1.City = "Gurgaon";
            address1.State = "Haryana";
            address1.Pin = 802151;
            address2.Name = "Model Town";
            address2.City = "Noida";
            address2.State = "Uttar Pradesh";
            address2.Pin = 802158;
            Console.WriteLine("Address 1 Name : {0}", address1.Name);
            Console.WriteLine("Address 1 City : {0}", address1.City);
            Console.WriteLine("Address 1 State: {0}", address1.State);
            Console.WriteLine("Address 1 Pin: {0}", address1.Pin);
            Console.WriteLine("");
            Console.WriteLine("Address 2 Name: {0}", address2.Name);
            Console.WriteLine("Address 2 City: {0}", address2.City);
            Console.WriteLine("Address 2 State: {0}", address2.State);
            Console.WriteLine("Address 2 Pin: {0}", address2.Pin);
        }
    }
}
