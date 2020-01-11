using System;

namespace RentAPI.Data
{
    public class Rent
    {
        public Guid RentId { get; set; }
        public Guid LocationId { get; set; }
        public Guid UserId { get; set; }
        public Guid ScooterInstanceId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCancelled { get; set; }

        public Rent()
        {
            RentId = Guid.NewGuid();
        }

        public static Rent Create(string locationId, string userId, string scooterInstanceId, DateTime startDate, DateTime endDate)
        {
            return new Rent
            {
                RentId = Guid.NewGuid(),
                LocationId = Guid.Parse(locationId),
                UserId = Guid.Parse(userId),
                ScooterInstanceId = Guid.Parse(scooterInstanceId),
                OrderDate = DateTime.UtcNow,
                IsCancelled = false,
                StartDate = startDate,
                EndDate = endDate
            };

        }
    }
}
