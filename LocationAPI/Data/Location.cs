using System;

namespace LocationAPI.Data
{
    public class Location
    {
        public Guid LocationID { get; set; }
        public Guid AddressID { get; set; }
        public bool valid { get; set; }
        public Location()
        {
            LocationID = Guid.NewGuid();
        }

        public static Location Create(string addressID)
        {
            return new Location
            {
                LocationID = Guid.NewGuid(),
                AddressID = Guid.Parse(addressID),
                valid = true
            };
        }
    }
}
