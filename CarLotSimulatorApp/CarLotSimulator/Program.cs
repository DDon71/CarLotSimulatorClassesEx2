using System;
using System.Reflection;
using CarLotSimulator;
using static CarLotSimulator.Cars;
using static CarLotSimulator.CarLot;

namespace CarLotSimulator
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car-done
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            var lot = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class

            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            var Vehicle1 = new Cars()
            {
                Year = 2021,
                Make = "Ferrari",
                Model = "SF90",
                EngineNoise = "Roadster",
                HonkNoise = "Truck Horn",
                isDrivable = true,

            };

            lot.CarType.Add(Vehicle1);

            Console.WriteLine();
            var Vehicle2 = new Cars()
            {
                Year = 2023,
                Make = "Ferrari",
                Model = "Purrosounge",
                EngineNoise = "V12",
                HonkNoise = "SUV Horn",
                isDrivable = false,

            };

            lot.CarType.Add(Vehicle2);

            Console.WriteLine();
            var Vehicle3 = new Cars()
            {
                Year = 2018,
                Make = "McLaren",
                Model = "Speedtail",
                EngineNoise = "V8",
                HonkNoise = "Truck Horn",
                isDrivable = true,

            };

            lot.CarType.Add(Vehicle3);

            Vehicle1.MakeEngineNoise(Vehicle1.EngineNoise);
            Vehicle1.MakeHonkNoise(Vehicle1.HonkNoise);
            Console.WriteLine();
            Vehicle2.MakeEngineNoise(Vehicle2.EngineNoise);
            Vehicle2.MakeHonkNoise(Vehicle2.HonkNoise);
            Console.WriteLine();
            Vehicle3.MakeEngineNoise(Vehicle3.EngineNoise);
            Vehicle3.MakeHonkNoise(Vehicle3.HonkNoise);

            Console.WriteLine();
            foreach(var car in lot.CarType)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}

