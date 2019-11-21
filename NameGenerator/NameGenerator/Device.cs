using System;
namespace NameGenerator
{
    /// <summary>
    /// List of ranked processors. If your processor isn't in this list, feel
    /// free to add it. Items at the beginning are lowest ranked, whilst items
    /// at the end are highest ranked.
    /// i.e. Core Duo is a very low (poor) ranked processor, while Core i9 is a
    /// very high ranked processor.
    /// </summary>
    public enum Core
    {
        Duo, Duo2, ARM, ARM32, ARM64, A4, A6, Ryzen3, i3, A8, A10, Ryzen5, i5,
        Ryzen7, i7, Ryzen9, i9
    }

    /// <summary>
    /// If you wish to change the grouping between the perceived performance and
    /// the Device's name classification, modify this set of enums. Again, the
    /// left-most item is the lower value, the right most is the upper value.
    /// </summary>
    public enum Vehicle { Cruiser, Van, Truck, Intercepter }


    /// <summary>
    /// Device represent any kind of generic use computer or electronic, from a Raspberry Pi,
    /// to a MacBook Pro, or Server class Dell.
    /// </summary>
    public class Device
    {

        //Device name, i.e. MacBook Pro, iPhone 6s, Dell XPS 13
        public string Name { get; private set; }
        //Device type, i.e. Laptop, Phone, Tablet
        public string Type { get; private set; }
        //Processor of the device. Feel free to add your own above. 
        public Core Processor;
        //Age of the computer: 2015, 2011, 2004
        public int Age { get; private set; }
        //Amount of RAM the device has, measured in GB
        //(max accounted for in the calculation: 32GB)
        public int RAM { get; private set; }

        //Retain the device's assigned name (a vehicle)
        public Vehicle vehicle;

        public Device()
        {

        }

        /// <summary>
        /// Devices get a Rank, representative of the "power" of their machine
        /// Thus the device will have a rank out of __ points.
        /// </summary>
        /// <returns>INT PointValue</returns>
        public int FindDeviceRanking()
        {
            int points = 0;
            points += (int)Processor;


            return points;
        }

    }
}
