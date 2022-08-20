using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_GetNames
{
    public enum SocialMedia { Facebook, Instagram, LinkedIn, WhatsApp, Twitter};
    public enum Games { CallOfDuty, Ludo, Chess, PUBG}
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var name in Enum.GetNames(typeof(SocialMedia)))
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("===================================");

            foreach (var name in Enum.GetNames(typeof(Games)))
            {
                Console.WriteLine(name);
            }
        }
    }
}
