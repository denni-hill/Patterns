using System;
using System.Collections.Generic;
using Strategy.Cars;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CarBase> cars = new List<CarBase>()
            {
                new ElectricCar(),
                new SportCar(),
                new StolenCar(),
                new Truck()
            };

            foreach(CarBase car in cars)
            {
                car.Display();
                car.DisplayEngineType();
                car.DisplayExhaustLoudness();
                car.DisplayWheelsCount();
                Console.WriteLine("=====");
            }
        }
    }
}
