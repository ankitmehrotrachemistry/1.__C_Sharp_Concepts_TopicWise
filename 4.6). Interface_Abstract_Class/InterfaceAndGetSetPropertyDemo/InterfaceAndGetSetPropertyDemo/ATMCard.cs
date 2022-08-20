using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace InterfaceAndGetSetPropertyDemo
{
    class ATMCard : IPay
    {
        private List<Bank> _FirstBank;

        public List<Bank> LastBank
        {
            get { return _FirstBank; }
            set { _FirstBank = value; }
        }

        private string _number;

        public string Number
        {
            get { return _number; }
            set { _number = value;  }
        }

        public void Payment()
        {
            Console.WriteLine("Payment Method / {0}", this.Number);
        }

        public void CancelPayment()
        {
            Console.WriteLine("CancelPayment Method / {0}", this.Number);
        }
    }
}
