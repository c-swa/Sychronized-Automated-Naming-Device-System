using System;
namespace NameGenerator
{

    public enum Vehicle { Cruiser, Van, Truck, Intercepter }

    /// <summary>
    /// List of ranked processors. If your processor isn't in this list, feel
    /// free to add it. Items at the beginning are lowest ranked, whilst items
    /// at the end are highest ranked.
    /// i.e. Core Duo is a very low (poor) ranked processor, while Core i9 is a
    /// very high ranked processor.
    /// </summary>
    public enum Core
    {
        Duo, Duo2, ARM, ARM32, ARM64, A4, A6, A8, Ryzen3, i3, A10, Ryzen5, i5,
        Ryzen7, i7, Ryzen9, i9
    }
     

    public class Devices
    {

        public string Name { get; private set; }
        public string Type { get; private set; }
        public Core Processor;
        public int Age { get; private set; }
        public int RAM { get; private set; }
        
        public Vehicle vehicle;

        public Devices()
        {

        }

    }
}
