using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Intialize_Get_Set
{
    class Program
    {
        public class Cat
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public Cat()
            {
                
            }
            public Cat(string name)
            {
                Name = name;
            }
        }
        static void Main(string[] args)
        {
            Cat cat1 = new Cat { Age =  10, Name = "Kitty"};
            //Cat cat2 = new Cat("Kitty") { Age = 10};

            List<Cat> cats = new List<Cat>
            {
                new Cat { Name = "Sylvester", Age = 8 },
                new Cat { Name = "Whiskers", Age = 2 },
                new Cat { Name = "Sasha", Age = 14}
            };

            List<Cat> newCats = new List<Cat>
            {
                new Cat { Name = "Furrytail", Age = 5 },
                new Cat { Name = "Peaches", Age = 4 }
            };

            Console.WriteLine(cat1.Name + " , " +cat1.Age);

            foreach (Cat c in cats)
                Console.WriteLine(c.Name + " , " + c.Age);

            foreach (Cat c in newCats)
                if (c != null)
                    Console.WriteLine(c.Name + " , " + c.Age);
                else
                    Console.WriteLine("Null Values in List");
        }
    }
}