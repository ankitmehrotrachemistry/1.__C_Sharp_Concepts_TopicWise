using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_GetValues
{
    public enum SocialNetworks { Facebook = 3, LinkedIn = 4, Twitter = 5, Instagram = 8};
    public enum MobilePhone { Samsung = 3, Nokia = 4, Redmi = 5, Xiomi = 8};
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var val in Enum.GetValues(typeof(SocialNetworks)))
            {
                Console.WriteLine((int)val);
            }

            Console.WriteLine("====================================");

            /*foreach (var val in Enum.GetValues<MobilePhone>())
            {
                Console.WriteLine((int)val);
            }*/
        }
    }
}
