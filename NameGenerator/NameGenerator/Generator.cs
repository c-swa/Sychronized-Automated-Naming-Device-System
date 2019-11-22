using System;
using System.Collections.Generic;


namespace NameGenerator
{
    public class Generator
    {
        List<Device> Devices = new List<Device>();
        static Random randomNumber = new Random();

        /// <summary>
        /// If an array of devices already exists, then this passes a new set
        /// into the list.
        /// </summary>
        /// <param name="devices"></param>
        public Generator(Device[] devices)
        {
            for(int count = 0; count < devices.Length; count++)
            {
                Devices.Add(devices[count]);
            }
        }

        /// <summary>
        /// Creates a default list with the maximum possible set of options at
        /// index 0. 
        /// </summary>
        public Generator()
        {
            Devices.Add(new Device("max","desktop",Core.i9,2019,32));
        }

        /// <summary>
        /// Creates a full name for the device.
        /// </summary>
        /// <param name="dev"></param>
        /// <returns>Name as a string</returns>
        public string createName(Device dev)
        {
            string Name = "";
            switch (dev.Type)
            {
                case "desktop":
                    Name += "CIA-";
                    break;
                case "laptop":
                    Name += "NASA-";
                    break;
                case "mobile":
                    Name += "SecretService-";
                    break;
                case "iot":
                    Name += "NSA-";
                    break;
                default:
                    Name = "KCPD-";
                    break;
            }

            switch (dev.GiveName())
            {
                case Vehicle.Cruiser:
                    Name += "Cruiser-";
                    break;
                case Vehicle.Van:
                    Name += "Van-";
                    break;
                case Vehicle.Truck:
                    Name += "Truck-";
                    break;
                case Vehicle.Intercepter:
                    Name += "Intercepter-";
                    break;
                default:
                    Name += "Cruiser-";
                    break;
            }
            Name += randomNumber.Next(10, 100).ToString();
            return Name;
        }

        /// <summary>
        /// Adds a device to the list: Devices.
        /// </summary>
        /// <param name="device"></param>
        public void AddDevice(Device device)
        {
            Devices.Add(device);
        }

    }
}
