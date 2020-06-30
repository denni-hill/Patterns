using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Engine
{
    public class SportEngine : IEngineable
    {
        public void Display()
        {
            Console.WriteLine("Engine type: sport");
        }
    }
}
