using System.Collections.Generic;
using TheArtOfExtensions.Extensions;

namespace TheArtOfExtensions.Models
{
    public class CarParking
    {
        public List<Car> Cars { get; } = new List<Car>();

        public void ParkCar(Car car)
        {
            Cars.Upsert(car, x => x.RegNo == car.RegNo);
        }
    }
}