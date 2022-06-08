using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var lot = new CarLot();
            

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var civic = new Car();
            
                civic.Year = 2013;
                civic.Make = "Honda";
                civic.Model = "Civic";
                civic.IsDriveable = true;
                civic.EngineNoise = "Vreeewwwm";
                civic.HonkNoise = "beep";

            lot.Cars.Add(civic);

            Console.WriteLine(CarLot.numberOfCars);

            var ridge = new Car();
            
                ridge.Year = 2011;
                ridge.Make = "Honda";
                ridge.Model = "Ridgeline";
                ridge.IsDriveable = true;
                ridge.EngineNoise = "VRAAAAM";
                ridge.HonkNoise = "BEEEP!";
            Console.WriteLine(CarLot.numberOfCars);
            lot.Cars.Add(ridge);

            var camaro = new Car();
            camaro.Year = 1968;
            camaro.Make = "Chevy";
            camaro.Model = "Camaro";
            camaro.IsDriveable = false;
            camaro.EngineNoise = "BRRRAPPPP";
            camaro.HonkNoise = "Beaaaap";
            lot.Cars.Add(camaro);
            Console.WriteLine(CarLot.numberOfCars);
            Console.WriteLine(camaro.Year);
            Console.WriteLine(camaro.EngineNoise);

            var fordT = new Car();
            fordT.Year = 2022;
            fordT.Make = "Ford";
            fordT.Model = "F150";

            Console.WriteLine(CarLot.numberOfCars);

            var ford = new Car();

            Console.WriteLine(CarLot.numberOfCars);




            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class DONE
            //It should have at least one property: a List of cars DONE
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            //foreach (var car in lot.Cars)
            {
                //Console.WriteLine($"Year:{car.Year}, Make:{car.Make}, Model:{car.Model}");


            }

        }
    }
}
