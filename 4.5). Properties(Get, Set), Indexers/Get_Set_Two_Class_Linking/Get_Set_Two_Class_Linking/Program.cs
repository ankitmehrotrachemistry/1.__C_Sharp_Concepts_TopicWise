using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Set_Two_Class_Linking
{
    class Program
    {
        static void Main(string[] args)
        {
            JackPotWin jpWin = new JackPotWin 
            {
                JackPotId = "Ankit",
                WinnerId = 2244,
                TierPosition = 12,
                Value = 4488
            };

            Console.WriteLine(" JackPotId : " + jpWin.JackPotId);
            Console.WriteLine(" WinnerId : " + jpWin.WinnerId);
            Console.WriteLine(" TierPosition : " + jpWin.TierPosition);
            Console.WriteLine(" Value : " + jpWin.Value);

            JackPotWinRequest jpWin1 = new JackPotWinRequest
            {
                position = 12
            };
        }
    }
}
