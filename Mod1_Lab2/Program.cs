using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating a Car object using type inference
            var Car1 = new Car();
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;


            var Car2 = new Car("Red", 2008);

            // Access static member
            int carCount = Car.CountCars();

            // Output to the console window
            Console.WriteLine($"There are {carCount} cars in inventory right now.");
        }
    }

    // Declaring the Car() class
    public class Car
    {
        // Defining properties
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        // Adding a constructor
        // This constructor instantiates a new Car when only the color and year are available.
        public Car (string color, int year)
        {
            this.Color = color;
            this.Year = year;

            // Increment the number of car instances
            instances++;
        }

        // Adding another constructor
        // This constructor instantiates a new Car using the year and mileage.
        public Car (int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;

            // Increment the number of car instances
            instances++;
        }

        // Creates integer variable called "instances" and assigns it a value of 0.
        private static int instances = 0;
        
        public Car()
        {
            // Increment instances every time the constructor runs
            instances++;
        }

        // Declare static member that returns the instance count
        public static int CountCars()
        {
            return instances;
        }
            
    }

}
