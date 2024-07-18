using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_OneKey_MultipleValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionaryGames = new Dictionary<string, string>
            {
                {"Shooting Games : ", "Black OPS, Call of Duty"},
                {"Runner Games : ", "Temple Run, Subway Surfers"},
                {"Platormer Games :", "Dave, Mario"},
                {"Arcade Games : ", "Pong, PacMan"}
            };

            Console.WriteLine("Accessing the Dictionary Elements");
            foreach (KeyValuePair<string, string> kvp in dictionaryGames)
            {
                Console.WriteLine($"Key : {kvp.Key}, Value : {kvp.Value}");
            }
        }
    }
}
