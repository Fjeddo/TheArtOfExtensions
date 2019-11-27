using System.Collections.Generic;
using TheArtOfExtensions.Extensions;

namespace TheArtOfExtensions.Models
{
    public class BikeParking
    {
        public List<Bike> Bikes { get; } = new List<Bike>();

        public void ParkBike(Bike bike)
        {
            Bikes.Upsert(bike, x => x.RegNo == bike.RegNo);
        }
    }
}