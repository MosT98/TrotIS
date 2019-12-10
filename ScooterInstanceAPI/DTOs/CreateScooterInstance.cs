using MediatR;
using ScooterInstanceAPI.Data;

namespace ScooterInstanceAPI.DTOs
{
    public class CreateScooterInstance : IRequest<ScooterInstance>
    {
        public int ScooterAutonomy { get; set; } //km
        public Scooter Scooter { get; set; } 
    }
}
