using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Engine;
using Strategy.Exhaust;
using Strategy.Wheels;

namespace Strategy.Cars
{
    public class Truck : CarBase
    {
        public Truck()
        {
            engineBehaviour = new PowerfulEngine();
            exhaustBehaviour = new SimpleExhaust();
            wheelsBehaviour = new SixWheels();
        }

        public override void Display()
        {
            Console.WriteLine("It's truck");
        }
    }
}
