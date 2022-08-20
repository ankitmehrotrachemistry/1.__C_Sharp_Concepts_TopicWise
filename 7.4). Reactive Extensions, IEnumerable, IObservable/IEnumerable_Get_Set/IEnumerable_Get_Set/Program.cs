using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_Get_Set
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Shop : IEnumerable
    {
        private Customer[] CustomerArray = new Customer[4];
        public Shop()
        {
            CustomerArray[0] = new Customer() { Id = 1, Name = "Ankit"};
            CustomerArray[1] = new Customer() { Id = 2, Name = "Shipra" };
            CustomerArray[2] = new Customer() { Id = 3, Name = "Daniel" };
            CustomerArray[3] = new Customer() { Id = 4, Name = "Funky" };
        }
        public IEnumerator GetEnumerator()
        {
            return CustomerArray.GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shop objShop = new Shop();

            foreach (Customer cust in objShop)
            {
                Console.WriteLine(cust.Name);
            }
        }
    }
}