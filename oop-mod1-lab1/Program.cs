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

    // declare car class
    public class Car
    {
        //Define properties of car
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

		//Adding a constructor with only color & year
		public Car(string color, int year)
		{
			this.Color = color;
			this.Year = year;
            // Every time the constructor runs, increment "instances"
            instances++;
		}
		
		//Add another constructor with year and mileage
		public Car(int year, int mileage)
		{
			this.Year = year;
			this.Mileage = mileage;
            // Every time the constructor runs, increment "instances"
            instances++;
		}

        //create int variable called "instances" and assigns value to 0
        private static int instances = 0;

        public Car()
        {
            //every time constructor runs, increment instances
            instances++;
        }

        //declare static member
        public static int CountCars()
        {
            return instances;
        }
    }

	


}
