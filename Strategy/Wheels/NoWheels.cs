using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Wheels
{
    public class NoWheels : IWheelable
    {
        public void DisplayWheelsCount()
        {
            Console.WriteLine("Car has no wheels");
        }
    }
}
