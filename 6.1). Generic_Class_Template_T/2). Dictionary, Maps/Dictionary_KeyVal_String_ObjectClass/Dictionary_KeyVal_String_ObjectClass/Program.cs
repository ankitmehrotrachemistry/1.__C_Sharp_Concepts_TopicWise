using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_KeyVal_String_ObjectClass
{
    class Program
    {
        public class JackpotEngine
        {
            public string JackPotName { get; set; }
            public int JackpotID { get; set; }
        }
        static void Main(string[] args)
        {
            Dictionary<string, JackpotEngine> jackpot = new Dictionary<string, JackpotEngine>();

            var jp1 = new JackpotEngine { JackPotName = "Grand", JackpotID = 1 };
            var jp2 = new JackpotEngine { JackPotName = "Major", JackpotID = 2 };
            var jp3 = new JackpotEngine { JackPotName = "Minor", JackpotID = 3 };
            var jp4 = new JackpotEngine { JackPotName = "Mini", JackpotID = 4 };

            jackpot.Add("JACK1", jp1);
            jackpot.Add("JACK2", jp2);
            jackpot.Add("JACK3", jp3);
            jackpot.Add("JACK4", jp4);

            Console.WriteLine("Total Elements : {0}", jackpot.Count);

            foreach (KeyValuePair<string, JackpotEngine> kvp in jackpot)
            {
                Console.WriteLine("KEY : " + kvp.Key.ToString() + ", VALUE : [" +kvp.Value.JackpotID + "," +kvp.Value.JackPotName + "]");
            }
        }
    }
}
