using System;
using System.Collections.Generic;
using TheArtOfExtensions.Classes;

namespace TheArtOfExtensions
{
    class Program
    {
        static void Main()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle {RegNo = "ABC123", Color = "yellow", Year = 2019},
                new Vehicle {RegNo = "DEF456", Color = "red", Year = 2018}
            };

            Console.WriteLine("List<T>.TryFindIndex(...)");
            var didFindIndex = vehicles.TryFindIndex(x => x.RegNo == "DEF456", out var index1);
            Console.WriteLine($"Vehicle found = {didFindIndex} @ index = {index1}");

            var didNotFindIndex = vehicles.TryFindIndex(x => x.RegNo == "CBA321", out var index2);
            Console.WriteLine($"Vehicle found = {didNotFindIndex} @ index = {index2}");

            Console.WriteLine("-----------------------");
            Console.WriteLine("List<T>.Upsert(...)");
            
            var blue = new Vehicle {RegNo = "GHI789", Color = "blue", Year = 2017};
            vehicles.Upsert(blue, vehicle => vehicle.RegNo == "GHI789");
            Console.WriteLine($"List length = {vehicles.Count}");

            var green = new Vehicle { RegNo = "GHI789", Color = "green", Year = 2017 };
            vehicles.Upsert(green, vehicle => vehicle.RegNo == "GHI789");
            Console.WriteLine($"List length = {vehicles.Count}");

            var black = new Vehicle { RegNo = "JKL012", Color = "black", Year = 1977 };
            vehicles.Upsert(black, vehicle => vehicle.RegNo == "JKL012");
            Console.WriteLine($"List length = {vehicles.Count}");
        }
    }

    class Vehicle
    {
        public string RegNo { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}
