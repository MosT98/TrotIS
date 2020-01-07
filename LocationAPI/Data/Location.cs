using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationAPI.Data
{
    public class Location
    {
        public Guid LocationID { get; set; }
        public Guid AddressID { get; set; }
        public List<Guid> ScooterInstanceIDs { get; set; }

        public Location()
        {
            LocationID = Guid.NewGuid();
        }

        public static Location Create(string addressID, List<string> scooterInstanceIDs)
        {
            return new Location
            {
                LocationID = Guid.NewGuid(),
                AddressID = Guid.Parse(addressID),
                ScooterInstanceIDs = scooterInstanceIDs.Select( scooter => { 
                        return Guid.Parse(scooter); 
                    }).ToList()
            };
        }
    }
}
