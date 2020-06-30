using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Exhaust
{
    public class DirectExhaust : IExhaustable
    {
        public void SoundLoudness()
        {
            Console.WriteLine("Sound loudness: very loud");
        }
    }
}
