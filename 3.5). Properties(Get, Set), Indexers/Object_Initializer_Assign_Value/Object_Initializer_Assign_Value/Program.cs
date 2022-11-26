using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Initializer_Assign_Value
{
    class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player { ID = 100, Name = "Ankit", Title = "Vatoke" };
            Console.WriteLine(player.ID);
            Console.WriteLine(player.Name);
            Console.WriteLine(player.Title);
        }
    }
}
