using System;

namespace Mod1_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an object of Car() Class by using Type Inference called Car1
            var Car1 = new Car();

            // Using dot notation to call members on Car1
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            // Output to the console window
            Console.WriteLine($"This car is painted {Car1.Color}, was built in {Car1.Year}, and has {Car1.Mileage} miles on it.");

            var Car2 = new Car("Red", 2008);

        }
    }
    // Declaring the Car() class
    // This class has 3 properties: Color, Year, and Mileage
    public class Car
    {
        // Defining properties
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        // Adding a Constructor
        // This constructor instantiates a Car() object while only having the car's color and year information available
        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
        }

        // Adding a Constructor
        //This constructor instantiates a Car() object while only having the car's year and mileage information available
        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
        }

        // Create integer variable and assign value to 0
        private static int instances = 0;

        public Car()
        {
            // Increment every time a constructor runs
            instances++;
        }

        // Declare static number
        public static int CountCars()
        {
            return instances;
        }


    }
}
