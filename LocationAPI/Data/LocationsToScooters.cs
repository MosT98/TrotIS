using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocationAPI.Data
{
    [NotMapped]
    public class LocationsToScooters
    {
        public Guid LocationID { get; set; }
        public Guid ScooterInstanceID { get; set; }

        public LocationsToScooters()
        {
        }

        public static List<LocationsToScooters> CreateMany(Guid locationID, List<Guid> scooterInstanceID)
        {
            List<LocationsToScooters> finalList = new List<LocationsToScooters>();
            foreach (var scooterInstance in scooterInstanceID)
                finalList.Add(new LocationsToScooters()
                {
                    LocationID = locationID,
                    ScooterInstanceID = scooterInstance

                }
            );
            return finalList;
        }

        public static LocationsToScooters Create(Guid locationID, Guid scooterInstanceID)
        {
            return new LocationsToScooters()
            {
                LocationID = locationID,
                ScooterInstanceID = scooterInstanceID
            };
        }
    }
}
