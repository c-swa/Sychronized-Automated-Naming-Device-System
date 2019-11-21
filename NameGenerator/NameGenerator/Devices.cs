using System;
namespace NameGenerator
{

    public enum Vehicle { Cruiser, Van, Truck, Intercepter }

    public class Devices
    {

        public string Type { get; private set; }
        public string Association { get; private set; }
        public Vehicle vehicle;

        public Devices(string t, string a, int power)
        {
            Type = t;
            Association = a;
            switch (power) {
                case 1:
                    vehicle = Vehicle.Cruiser;
                    break;
                case 2:
                    vehicle = Vehicle.Van;
                    break;
                case 3:
                    vehicle = Vehicle.Truck;
                    break;
                case 4:
                    vehicle = Vehicle.Intercepter;
                    break;
                default:
                    vehicle = Vehicle.Cruiser;
                    break;
            }
        }

    }
}
