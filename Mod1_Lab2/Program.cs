using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab2

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

}
