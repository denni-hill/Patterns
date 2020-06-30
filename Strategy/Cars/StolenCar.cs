using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Engine;
using Strategy.Exhaust;
using Strategy.Wheels;

namespace Strategy.Cars
{
    public class StolenCar : CarBase
    {
        public StolenCar()
        {
            engineBehaviour = new SimpleEngine();
            exhaustBehaviour = new SimpleExhaust();
            wheelsBehaviour = new NoWheels();
        }

        public override void Display()
        {
            Console.WriteLine("It's stolen car");
        }
    }
}
