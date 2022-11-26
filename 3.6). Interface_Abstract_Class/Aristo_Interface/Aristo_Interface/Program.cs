using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aristo_Interface
{
    public interface Vehicle
    {
        string BikeId { get; set; }
        void SpeedUp(int a);
    }

    class Bike : Vehicle {
        int speed;
        private string _bikeId;
        public string BikeId
        {
            get => _bikeId;
            set => _bikeId = value;
        }
        public void SpeedUp(int i)
        {
            speed = speed + i;
        }
        public void printSpeed()
        {
            Console.WriteLine("Bike Speed is " +speed);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bike b = new Bike();

            b.SpeedUp(150);

            b.printSpeed();

            b.BikeId = "BR5462";

            Console.WriteLine("Bike ID is : "+b.BikeId);
        }
    }
}
