using System;
using System.Collections.Generic;
using TheArtOfExtensions.Classes;

namespace TheArtOfExtensions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("List<T>.Upsert(...)");
            var vehicles = new List<Vehicle>
            {
                new Vehicle {RegNo = "ABC123", Color = "yellow", Year = 2019},
                new Vehicle {RegNo = "DEF456", Color = "red", Year = 2018}
            };

            var blue = new Vehicle {RegNo = "GHI789", Color = "blue", Year = 2017};
            vehicles.Upsert(blue, vehicle => vehicle.RegNo == "GHI789");

            var green = new Vehicle { RegNo = "GHI789", Color = "green", Year = 2017 };
            vehicles.Upsert(green, vehicle => vehicle.RegNo == "GHI789");
        }
    }

    class Vehicle
    {
        public string RegNo { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}
