using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Search_LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> playerList = new Dictionary<string, int>();

            playerList.Add("Harry Potter", 1248);
            playerList.Add("Ankit Kumar", 540);
            playerList.Add("Bubbly Kumari", 1600);
            playerList.Add("Sahil Rastogi", 864);
            playerList.Add("Charlie Dughiee", 1848);
            playerList.Add("Hal Elrodd", 448);
            playerList.Add("Cal Newport", 1000);
            playerList.Add("Nauni Kumar", 1000);

            var findElem = from x in playerList
                           where x.Key.Contains("Kumar")
                           select x;

            foreach (var result in findElem)
            {
                Console.WriteLine("Player Name is {0}, Score {1}", result.Key, result.Value);
            }

            Console.WriteLine("=========================================");

            var findElem2 = playerList.Where(x => x.Key.Contains("Kumar"));

            foreach (var result in findElem)
            {
                Console.WriteLine("Player Name is {0}, Score {1}", result.Key, result.Value);
            }
        }
    }
}
