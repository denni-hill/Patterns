using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Exhaust
{
    public class NoExhaust : IExhaustable
    {
        public void SoundLoudness()
        {
            Console.WriteLine("Sound loudness: zero");
        }
    }
}
