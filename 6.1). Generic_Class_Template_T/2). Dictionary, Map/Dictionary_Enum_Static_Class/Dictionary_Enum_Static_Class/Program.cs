using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Enum_Static_Class
{
    public static class Constants
    {
        public const string Jackpot_Minor = "MinorJackPot";
        public const string Jackpot_Major = "MajorJackPot";
        public const string Jackpot_Grand = "GrandJackPot";
    }
    public enum FloatingWildValue
    {
        Invalid = 0, Credit = 1, Bonus = 2, Minor = 3, Major = 4, Grand = 5
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, FloatingWildValue> CalculateJackpotType = new Dictionary<string, FloatingWildValue>()
            {
                {Constants.Jackpot_Minor, FloatingWildValue.Minor},
                {Constants.Jackpot_Major, FloatingWildValue.Major},
                {Constants.Jackpot_Grand, FloatingWildValue.Grand}
            };

            var dict2 = CalculateJackpotType.Where(x => x.Value == FloatingWildValue.Major)
                                            .Select(x => x);

            foreach (var result in dict2)
            {
                Console.WriteLine("Value of Dictionary is : "+  " '" + result.Key +  "' "+ " and Value is : " +result.Value);
            }
            Console.WriteLine(FloatingWildValue.Grand);
        }
    }
}
