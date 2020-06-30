using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Exhaust
{
    public class SimpleExhaust : IExhaustable
    {
        public void SoundLoudness()
        {
            Console.WriteLine("Sound Loudness: medium");
        }
    }
}
