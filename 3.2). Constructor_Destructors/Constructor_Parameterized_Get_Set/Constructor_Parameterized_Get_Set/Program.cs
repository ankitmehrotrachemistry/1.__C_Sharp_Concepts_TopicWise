using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Parameterized_Get_Set
{
    public class PlayerName
    {
        string name = string.Empty;
        public string Name { get; set; }
        public PlayerName()
        {
            name = "Ankit";
            Console.WriteLine("Name in Default Constructor is : " +name);
        }
        public PlayerName(string name)
        {
            this.Name = name;
            Console.WriteLine("Name in Parameterized Constructor is : "+Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PlayerName p1 = new PlayerName();
            PlayerName p2 = new PlayerName("Satish");
        }
    }
}
