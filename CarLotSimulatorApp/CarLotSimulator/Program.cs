﻿using System;
using System.Collections.Generic;
namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            Car MyCar = new Car();
            MyCar.Year = 1998;
            MyCar.Make = "GMC";
            MyCar.Model = "Jimmmy";
            MyCar.IsDriveable = true;
            MyCar.EngineNoise = "vrooom";
            MyCar.HonkNoise = "beep";
            MyCar.IsDriveable = true;

            MyCar.MakeEngineNoise();
            MyCar.MakeHonkNoise();

                
            Car Honda = new Car() { Make = "Honda", Model = "Accord", Year = 2015, HonkNoise = "beeep", EngineNoise = "vrooooom" };
            Honda.MakeHonkNoise();
            Honda.MakeEngineNoise();

            Car BMW = new Car("BMW", "i8", 2020, "booop", "VRMMMMMMM");
            BMW.MakeEngineNoise();
            BMW.MakeHonkNoise();
            


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
        }
    }
}
