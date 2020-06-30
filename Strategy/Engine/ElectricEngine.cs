using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Engine
{
    public class ElectricEngine : IEngineable
    {
        public void Display()
        {
            Console.WriteLine("Engine type: electric engine");
        }
    }
}
