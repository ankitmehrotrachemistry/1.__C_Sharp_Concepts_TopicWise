using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Linking1
{
    class Program
    {
        static void Main(string[] args)
        {
            var jackpot = new Jackpot();
            var dataValue = new DataValue();

            int tierPosition = jackpot.TierPosition = dataValue.tierPos;
            int tempId = jackpot.TemplateID = dataValue.tempID;
            ulong wagerAmount = jackpot.Wager = dataValue.wager;
            ulong userID = jackpot.UserId = dataValue.userId;

            Console.WriteLine("Value of TierPos is : " +tierPosition);
            Console.WriteLine("Value of TempId is : " + tempId);
            Console.WriteLine("Value of WagerAmount is : " + wagerAmount);
            Console.WriteLine("Value of UserID is : " + userID);
        }
    }
}
