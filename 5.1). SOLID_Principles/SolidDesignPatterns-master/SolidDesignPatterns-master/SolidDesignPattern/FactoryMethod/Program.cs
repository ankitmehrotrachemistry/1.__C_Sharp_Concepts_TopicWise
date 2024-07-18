﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Factory Method in the design patterns.");
            //-------------------------------------------------------------------//
            IBank bank = BankFactory.GetBank(BankType.Vietcombank);
            Console.WriteLine(bank.GetBankName());
        }
    }
}
