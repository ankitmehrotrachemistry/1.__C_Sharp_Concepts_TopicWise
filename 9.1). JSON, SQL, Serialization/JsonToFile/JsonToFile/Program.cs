using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace JsonToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Config config = new Config()                                               
            {
                token = "t0k3n",
                port = 2121,
                timeStamp = DateTime.Now,
                tags = new List<string>() { "string1", "string2", "string3" }
            };
            JsonToFile(config, "config.json");                                          
            Config configFromFile = ConfigReader("config.json");                        
            Console.WriteLine(configFromFile.token);
        }
        public static void JsonToFile(object Object, string path)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();               
            options.WriteIndented = true;                                               
            string json = JsonSerializer.Serialize(Object, typeof(Object), options);   
            File.WriteAllText("config.json", json);                                    
        }

        public static Config ConfigReader(string path)
        {
            string json = File.ReadAllText(path);                                      
            return JsonSerializer.Deserialize<Config>(json);                        
        }
        public class Config                                                             
        {
            public string token { get; set; }
            public int port { get; set; }
            public DateTime timeStamp { get; set; }
            public List<string> tags { get; set; }
        }
    }
}
