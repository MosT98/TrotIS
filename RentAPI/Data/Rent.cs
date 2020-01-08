using System;

namespace RentAPI.Data
{
    public class Rent
    {
        public Guid RentID { get; set; }
        public Guid LocationID { get; set; }
        public Guid UserID { get; set; }
        public Guid ScooterInstanceID { get; set; }
        public DateTime RentDate { get; set; }
        public bool IsCancelled { get; set; }

        public Rent()
        {
            RentID = Guid.NewGuid();
        }

        public static Rent Create(string locationID, string userID, string scooterInstanceID, DateTime rentDate)
        {
            return new Rent
            {
                RentID = Guid.NewGuid(),
                LocationID = Guid.Parse(locationID),
                UserID = Guid.Parse(userID),
                ScooterInstanceID = Guid.Parse(scooterInstanceID),
                RentDate = rentDate,
                IsCancelled = false
            };

        }
    }
}
