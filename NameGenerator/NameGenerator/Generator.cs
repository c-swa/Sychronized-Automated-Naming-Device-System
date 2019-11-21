using System;
using System.Collections.Generic;


namespace NameGenerator
{
    public class Generator
    {
        public Dictionary<Devices, int> Options = new Dictionary<Devices, int>();


        public Generator(Devices[] devices)
        {
            Random randomGeneration = new Random();
            for (int count = 0; count < devices.Length; count++)
            {
                Options.Add(devices[count], randomGeneration.Next(0, 100));
            }
        }

    }
}
