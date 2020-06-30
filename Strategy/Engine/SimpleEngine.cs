using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Engine
{
    public class SimpleEngine : IEngineable
    {
        public void Display()
        {
            Console.WriteLine("Engine type: simple");
        }
    }
}
