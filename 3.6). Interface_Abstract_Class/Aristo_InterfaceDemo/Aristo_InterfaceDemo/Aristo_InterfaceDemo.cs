using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aristo_InterfaceDemo
{
    interface IAmount
    {
        bool Debit(decimal amount);
        bool Credit(decimal amount);
        decimal BalanceAmount { get; }
    }

    public class Amount1 : IAmount
    {
        private decimal _money;
        public bool Debit(decimal amount)
        {
            _money += amount;
            return true;
        }
        public bool Credit(decimal amount)
        {
            if (_money < amount)
            {
                Console.WriteLine("Less");
                return false;
            }
            else
            {
                Console.WriteLine("More");
                return true;
            }
        }
        public decimal BalanceAmount
        {
            get { return _money; }
        }

        public override string ToString()
        {
            return String.Format("Saving Amount is : {0,6:C}", _money);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IAmount i1 = new Amount1();

            i1.Debit(50);
            i1.Credit(100);
            i1.ToString();
        }
    }
}
