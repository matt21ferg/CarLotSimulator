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
            Console.WriteLine($"number of cars in carlot is {CarLot.numberOfCars}");
        }
        public Car(string make,string model,int year,string honkNoise,string engineNoise,bool isDriveable = true)
        {
            Make = make;
            Model = model;
            Year = year;
            HonkNoise = honkNoise; 
            EngineNoise = engineNoise;

        }
        public string Make { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }
        public string HonkNoise { get; set; }
        public string EngineNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine($"{EngineNoise}");
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine($"{HonkNoise}");
        }
        CarLot example = new CarLot();
        



    
    
    
    }
}
