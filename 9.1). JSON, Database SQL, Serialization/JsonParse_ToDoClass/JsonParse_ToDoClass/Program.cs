using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonParse_ToDoClass
{
    class Program
    {
        HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            Program program = new Program();
            await program.GetToDoItems();
        }

        private async Task GetToDoItems()
        {
            string response = await client.GetStringAsync(
                "https://jsonplaceholder.typicode.com/todos");

            Console.WriteLine(response);

            List<Todo> todo = JsonConvert.DeserializeObject<List<Todo>>(response);

            foreach(var item in todo)
            {
                Console.WriteLine(item.title);
            }
        }
    }

    class Todo
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }
}
