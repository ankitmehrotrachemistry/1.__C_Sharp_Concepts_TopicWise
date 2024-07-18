using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Constructor_Inaccessible
{
    class User
    {
        private User()
        {
            Console.WriteLine("I am Private Constructor");
        }
        public static string Name, Location;
        public User(string name, string location)
        {
            Name = name;
            Location = location;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // User user1 = new User(); // Inaccessible due to it's protection level

            User user2 = new User("Ankit", "Buxar");
            Console.WriteLine(User.Name + " from " + User.Location);
        }
    }
}