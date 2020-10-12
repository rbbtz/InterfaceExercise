using System;
using System.Security.Cryptography.X509Certificates;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            SUV suv = new SUV();
            Truck truck = new Truck();
            Car car = new Car();
            bool isRunning = true;
            while (isRunning == true)
            {
                Console.Clear();
                Console.WriteLine("||==============||");
                Console.WriteLine("|| * (C)ar   *  ||");
                Console.WriteLine("|| * (T)ruck *  ||");
                Console.WriteLine("|| * (S)UV   *  ||");
                Console.WriteLine("|| * (Q)uit  *  ||");
                Console.WriteLine("||==============||");
                string input = Console.ReadLine();

                if(input.ToLower() == "c" || input.ToLower() == "car")
                {
                    Console.WriteLine("||=================||");
                    Console.WriteLine("||    (Features)   ||");
                    Console.WriteLine($"||-hasTrunk: {car.hasTrunk}  ||");
                    Console.WriteLine($"||-Top Speed: {car.topSpeed}||");
                    Console.WriteLine($"||-{car.CompanyName}          ||");
                    Console.WriteLine($"||-Wheels: {car.Wheels}       ||");
                    Console.WriteLine($"||-Seats: {car.Seats}        ||");
                    Console.WriteLine($"||-Model: {car.Model}      ||");
                    Console.WriteLine("||=================||");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (input.ToLower() == "t" || input.ToLower() == "truck")
                {
                    Console.WriteLine("||======================||");
                    Console.WriteLine("||      (Features)      ||");
                    Console.WriteLine($"||-hasBed: {truck.hasBed}         ||");
                    Console.WriteLine($"||-Carrying Cap: {truck.carryingCap}||");
                    Console.WriteLine($"||-{truck.CompanyName}               ||");
                    Console.WriteLine($"||-Wheels: {truck.Wheels}            ||");
                    Console.WriteLine($"||-Seats: {truck.Seats}             ||");
                    Console.WriteLine($"||-Model: {truck.Model}        ||");
                    Console.WriteLine("||======================||");
                    Console.ReadKey();
                }
                if (input.ToLower() == "s" || input.ToLower() == "suv")
                {
                    Console.WriteLine("||================||");
                    Console.WriteLine("||   (Features)   ||");
                    Console.WriteLine($"||-HasHatch: {suv.hasHatch} ||");
                    Console.WriteLine($"||-Seating Rows: {suv.Rows}||");
                    Console.WriteLine($"||-{suv.CompanyName}          ||");
                    Console.WriteLine($"||-Wheels: {suv.Wheels}      ||");
                    Console.WriteLine($"||-Seats: {suv.Seats}       ||");
                    Console.WriteLine($"||-Model: {suv.Model} ||");
                    Console.WriteLine("||================||");
                    Console.ReadKey();
                }
                if(input.ToLower() == "q" || input.ToLower() == "quit")
                {
                    Environment.Exit(-1);
                }

            }
            
        }
    }

    public interface IVehicle
    {
        public int Wheels { get; set; }
        public int Seats { get; set; }
        public bool isDriveable { get; set; }
        public string Model { get; set; }
    }
    public interface ICompany
    {
        public string Logo { get; set; }
        public string CompanyName { get; set; }
    }
}
