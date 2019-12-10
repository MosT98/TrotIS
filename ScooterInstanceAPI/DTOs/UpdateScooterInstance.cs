using System;
using MediatR;
using ScooterInstanceAPI.Data;

namespace ScooterInstanceAPI.DTOs
{
    public class UpdateScooterInstance : IRequest<ScooterInstance>
    {
        public Guid ScooterInstanceId { get; set; }

        public int ScooterAutonomy { get; set; } //km

        public Scooter Scooter { get; set; }
    }
}
