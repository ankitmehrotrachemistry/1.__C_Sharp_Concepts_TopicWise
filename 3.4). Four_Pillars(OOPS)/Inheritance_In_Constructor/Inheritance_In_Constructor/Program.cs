using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_In_Constructor
{
    class Vehicle
    {
        public string ManufacturerName { get; set; }
        public int YearOfManufacturing { get; set; }
    }
    class PublicVehicle : Vehicle
    {
        int AllowedPassengers { get; set; }
        public PublicVehicle(string name, int year, int count)
        {
            ManufacturerName = name;
            YearOfManufacturing = year;
            AllowedPassengers = count;
        }
        public string GetVehiclesDetails()
        {
            return $"Car manufactured by {ManufacturerName} in year {YearOfManufacturing} and {AllowedPassengers} can travel only";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PublicVehicle pub = new PublicVehicle("Toyota Hub", 1964, 150);
            var result = pub.GetVehiclesDetails();
            Console.WriteLine(result);
        }
    }
}