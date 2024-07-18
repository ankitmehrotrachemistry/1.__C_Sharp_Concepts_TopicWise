using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Multiple_Interface
{
    interface ILoanCustomer
    {
        void GetCustomerInfo();
    }
    interface IBankCustomer
    {
        void GetCustomerInfo();
    }
    class Customer : ILoanCustomer, IBankCustomer
    {
        void ILoanCustomer.GetCustomerInfo()
        {
            Console.WriteLine("Loan Customer");
        }
        void IBankCustomer.GetCustomerInfo()
        {
            Console.WriteLine("Bank Customer");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ILoanCustomer lc = new Customer();
            lc.GetCustomerInfo();

            IBankCustomer bc = new Customer();
            bc.GetCustomerInfo();
        }
    }
}
