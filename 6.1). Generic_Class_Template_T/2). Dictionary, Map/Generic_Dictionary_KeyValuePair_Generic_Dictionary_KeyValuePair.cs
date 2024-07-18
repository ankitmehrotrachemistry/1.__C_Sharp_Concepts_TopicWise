using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Dictionary_KeyValuePair
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> movie = new Dictionary<string, string>();

            movie.Add("Sci-Fi","Star Wars");
            movie.Add("Action","Kung Fu");
            movie.Add("Scientific","Beautiful Mind");
            movie.Add("Romantic","My Love");

            Console.WriteLine(movie["Action"]);

            foreach (KeyValuePair<string, string> item in movie)
            {
                Console.WriteLine(item.ToString());
            }

            if (movie.ContainsKey("Romantic"))
            {
                Console.WriteLine("Key Found and Value is : " + movie["Romantic"]);
            }
            else
            {
                Console.WriteLine("Key not found");
            }
        }
    }
}