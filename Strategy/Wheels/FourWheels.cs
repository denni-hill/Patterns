using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Wheels
{
    public class FourWheels : IWheelable
    {
        public void DisplayWheelsCount()
        {
            Console.WriteLine("Count of wheels: 4");
        }
    }
}
