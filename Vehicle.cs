using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    internal class Vehicle
    {
        protected string Brand;
        protected int Cost;

        public Vehicle(string brand, int cost)
        {
            this.Brand = brand;
            this.Cost = cost;
        }
        public void Drive()
        {
            Console.WriteLine($"The vehicle {Brand} costing {Cost} is ready to drive.");
        }
    }
    internal class Bike : Vehicle
    {
        private string color;
        public Bike(string brand, int cost, string color) : base(brand, cost)
        {
            this.color = color;
        }
        public void RideBike()
        {
            Console.WriteLine($"The bike {Brand} of type {color} is ready to ride.");
        }
    }
   /* class MainClass
    {
        static void Main(string[] args)
        {
            Bike b = new Bike("Suzuki", 40000, "Blue");
            b.Drive();
            b.RideBike();
        }   
    }*/
    
}
