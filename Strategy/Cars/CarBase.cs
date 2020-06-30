using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Engine;
using Strategy.Exhaust;
using Strategy.Wheels;

namespace Strategy.Cars
{
    public abstract class CarBase
    {
        protected IEngineable engineBehaviour;
        protected IExhaustable exhaustBehaviour;
        protected IWheelable wheelsBehaviour;

        public CarBase()
        {
            engineBehaviour = new SimpleEngine();
            exhaustBehaviour = new SimpleExhaust();
            wheelsBehaviour = new FourWheels();
        }

        public abstract void Display();

        public void DisplayEngineType()
        {
            engineBehaviour.Display();
        }

        public void DisplayExhaustLoudness()
        {
            exhaustBehaviour.SoundLoudness();
        }

        public void DisplayWheelsCount()
        {
            wheelsBehaviour.DisplayWheelsCount();
        }
    }
}
