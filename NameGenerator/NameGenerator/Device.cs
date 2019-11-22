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

        /// <summary>
        /// Generic Constructor to set up the devices.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="processor"></param>
        /// <param name="age"></param>
        /// <param name="ram"></param>
        public Device(string name, string type, Core processor, int age, int ram)
        {
            Name = name;
            Type = type;
            Processor = processor;
            Age = age;
            RAM = ram;
        }

        /// <summary>
        /// Devices get a Rank, representative of the "power" of their machine
        /// Thus the device will have a ranking based on a value of points.
        /// </summary>
        /// <returns>INT PointValue</returns>
        public int FindDeviceRanking()
        {
            int points = 0;
            points += (int)Processor;
            if (RAM > 32)
                points += 32;
            else
                points += RAM;
            if (Age < 2005)
                points = 1;
            else
            {
                points += 5;
                if (Age < 2010)
                    points += 0;
                else
                {
                    points += 10;
                }
            }
            return points;
        }

        /// <summary>
        /// Compares this Device to another. If a -1 is returned, this is less
        /// than other in ranking. If a 0 is returned, they are equal in ranking.
        /// If a 1 is returned, this is greater than other in ranking.
        /// </summary>
        /// <param name="other"></param>
        /// <returns>INT: -1, 0, 1</returns>
        public int CompareRanking(Device other)
        {
            if(this.FindDeviceRanking() > other.FindDeviceRanking())
            {
                return 1;
            } else if (this.FindDeviceRanking() < other.FindDeviceRanking())
            {
                return -1;
            } else
            {
                return 0;
            }
        }

        /// <summary>
        /// Finds the maximum potential value.
        /// </summary>
        /// <returns></returns>
        public int FindMaxRank()
        {
            int points = 0;
            //Best possible processor
            points += (int)Core.i9;
            //Newest age of device.
            points += 15;
            //Max RAM
            points += 32;

            return points;
        }

        /// <summary>
        /// Compares the Device ranking between this and the maximum possible for
        /// the given options.
        /// </summary>
        public Vehicle GiveName()
        {
            if ((double)this.FindDeviceRanking() < ((double)FindMaxRank() * 0.25))
                vehicle = Vehicle.Cruiser;
            else if ((double)this.FindDeviceRanking() < ((double)FindMaxRank() * 0.5))
                vehicle = Vehicle.Van;
            else if ((double)this.FindDeviceRanking() < ((double)FindMaxRank() * 0.75))
                vehicle = Vehicle.Truck;
            else
                vehicle = Vehicle.Intercepter;
            return vehicle;
        }
    }
}
