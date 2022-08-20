using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Interface
{
    class Program
    {
        public interface IPlayer<T>
        {
            string Name { get; set; }
            string GetPlayerName(T t);
        }
        public class OnlinePlayer : IPlayer<OnlinePlayer>
        {
            public string Name { get; set; }
            public string GetPlayerName(OnlinePlayer t)
            {
                return "Online Player is " + t.Name;
            }
        }
        public class OfflinePlayer : IPlayer<OfflinePlayer>
        {
            public string Name { get; set; }
            public string GetPlayerName(OfflinePlayer t)
            {
                return "Offline Player is " + t.Name;
            }
        }
        static void Main(string[] args)
        {
            OnlinePlayer onlinePlayer = new OnlinePlayer();
            onlinePlayer.Name = "Ankit";
            Console.WriteLine(onlinePlayer.GetPlayerName(onlinePlayer));

            OfflinePlayer offlinePlayer = new OfflinePlayer();
            offlinePlayer.Name = "Bajinder";
            Console.WriteLine(offlinePlayer.GetPlayerName(offlinePlayer));
        }
    }
}
