using System;

namespace RentAPI.Data
{
    public class Rent
    {
        public Guid RentId { get; set; }
        public Guid LocationId { get; set; }
        public Guid UserId { get; set; }
        public Guid ScooterInstanceId { get; set; }
        public DateTime RentDate { get; set; }
        public bool IsCancelled { get; set; }

        public Rent()
        {
            RentId = Guid.NewGuid();
        }

        public static Rent Create(string locationId, string userId, string scooterInstanceId)
        {
            return new Rent
            {
                RentId = Guid.NewGuid(),
                LocationId = Guid.Parse(locationId),
                UserId = Guid.Parse(userId),
                ScooterInstanceId = Guid.Parse(scooterInstanceId),
                RentDate = DateTime.UtcNow,
                IsCancelled = false
            };

        }
    }
}
