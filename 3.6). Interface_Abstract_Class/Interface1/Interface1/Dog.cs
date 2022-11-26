using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    class Dog : IAnimal
    {
        public void DogSound()
        {
            Console.WriteLine("Bhoww Bhoww");
        }
        public void DogName()
        {
            Console.WriteLine("My name is Katiya");
        }
    }
}
