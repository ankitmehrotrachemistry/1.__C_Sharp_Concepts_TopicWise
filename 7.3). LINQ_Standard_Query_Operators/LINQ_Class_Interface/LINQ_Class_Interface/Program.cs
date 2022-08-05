using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Class_Interface
{
    interface IRewardItem
    {
        string CurrencyType { get; set; }
        bool MultiplyWIn { get; set; }
    }
    interface IResults
    {
        IList<IRewardItem> WonRewards { get; set; }
    }
    class SpinData
    {
        public IList<IRewardItem> Bonus { get; set; }
        public IResults Results { get; set; }

    }
    class GameBaseContext
    {
        public SpinData SpinData { get; set; }
    }
    class Program : GameBaseContext
    {
        public void AddRewards(string currency, ulong credit)
        {
            IRewardItem existingReward = SpinData.Results.WonRewards
                                                  .Where(x => x.CurrencyType.Equals(currency))
                                                  .Select(x => x).FirstOrDefault();
        }
        static void Main(string[] args)
        {
            /*var var1 = new GameBaseContext
            {
                SpinData.Results.WonRewards
            };*/
            var var2 = new SpinData
            {
                
            };
        }
    }
}
