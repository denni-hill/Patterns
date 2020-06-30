using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Engine;
using Strategy.Exhaust;
using Strategy.Wheels;

namespace Strategy.Cars
{
    public class SportCar : CarBase
    {
        public SportCar()
        {
            engineBehaviour = new SportEngine();
            exhaustBehaviour = new DirectExhaust();
            wheelsBehaviour = new FourWheels();
        }
        public override void Display()
        {
            Console.WriteLine("It's sport car");
        }
    }
}
