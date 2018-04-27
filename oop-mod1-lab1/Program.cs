using System;

namespace oop_mod1_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate object of car class
            var Car1 = new Car();

            //call members on instantiated Car1
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            //Check output to see if properly instantiated
            //Console.WriteLine($"This car is {Car1.Color}, was built in {Car1.Year}, and has {Car1.Mileage} miles on it.");

            var Car2 = new Car("Red", 2008);

            //access static members
            int carCount = Car.CountCars();

            //output to console
            Console.WriteLine($"There are {carCount} cars in inventory.");
        }
    }

}
