using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Engine;
using Strategy.Exhaust;
using Strategy.Wheels;

namespace Strategy.Cars
{
    public class ElectricCar : CarBase
    {
        public ElectricCar()
        {
            engineBehaviour = new ElectricEngine();
            exhaustBehaviour = new NoExhaust();
            wheelsBehaviour = new FourWheels();
        }

        public override void Display()
        {
            Console.WriteLine("It's electric car");
        }
    }
}
