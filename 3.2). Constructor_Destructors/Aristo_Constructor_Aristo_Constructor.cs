using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aristo_Constructor
{
    public class Program
    {
        public int Id { get; set; }
        public string name { get; set; }
        public Program()
        {
            
        }
        public Program(string name)
        {
            this.name = name;
        }
        public Program(string name, int Id)
        {
            this.Id = Id;
            this.name = name;
        }
        
        static void Main(string[] args)
        {
            var Program1 = new Program();
            var Program2 = new Program("Ankit");
            var Program3 = new Program("Ankit", 107804);

            Console.WriteLine("Player Name is : " +Program2.name);
            Console.WriteLine("Player Name and Id is : " + Program3.name + " and " + Program3.Id + " respectively");
        }
    }
}
