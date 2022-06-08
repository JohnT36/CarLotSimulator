using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {

        public Car()
        {
            CarLot.numberOfCars++;
        }

        public Car(int year, string make, string model, bool isDriveable, string engineNoise, string honkNoise)
        {
            Year = year;
            Make = make;
            Model = model;
            IsDriveable = isDriveable;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
        }


        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool IsDriveable { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }

        public void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine(EngineNoise);
        }
        public void MakeHonkNoise(string HonkNoise)
        {
            Console.Write(HonkNoise);
        }     

        



    }
  
}
