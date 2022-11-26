using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Abstract_Methods
{
    interface Vehicle
    {
        void changeGear(int a);
        void speedUp(int a);
        void applyBreaks(int a);
    }
    class Bicycle : Vehicle
    {
        int speed;
        int gear;
        public void changeGear(int newGear)
        {
            gear = newGear;
        }
        
        public void speedUp(int increment)
        {
            speed = speed + increment;
        }

        public void applyBreaks(int decrement)
        {
            speed = speed - decrement;
        }
        public void PrintStates()
        {
            Console.WriteLine("Speed is : " +speed+ " gear is : "+gear);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycle = new Bicycle();

            bicycle.changeGear(2);
            bicycle.speedUp(4);
            bicycle.applyBreaks(1);
            Console.WriteLine("Bicycle Present State is :");
            bicycle.PrintStates();
        }
    }
}