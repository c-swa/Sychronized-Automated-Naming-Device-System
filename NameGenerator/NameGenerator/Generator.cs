using System;
using System.Collections.Generic;


namespace NameGenerator
{
    public class Generator
    {
        public Dictionary<Device, int> Options = new Dictionary<Device, int>();


        public Generator(Device[] devices)
        {
            Random randomGeneration = new Random();
            for (int count = 0; count < devices.Length; count++)
            {
                Options.Add(devices[count], randomGeneration.Next(0, 100));
            }
        }

    }
}
