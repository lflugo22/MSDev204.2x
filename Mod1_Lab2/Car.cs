using System;
using System.Collections.Generic;
using System.Text;

namespace Mod1_Lab2
{
    // Declaring the Car() class
    public class Car
    {
        // Defining properties
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        // Adding a constructor
        // This constructor instantiates a new Car when only the color and year are available.
        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;

            // Increment the number of car instances
            instances++;
        }

        // Adding another constructor
        // This constructor instantiates a new Car using the year and mileage.
        public Car(int year, int mileage)
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
