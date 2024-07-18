using System;

namespace InterfaceAndGetSetPropertyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank() {Name = "HDFC" };

            ATMCard atm = new ATMCard() { Number = "12" };
            atm.Payment();
            atm.CancelPayment();
        }
    }
}
