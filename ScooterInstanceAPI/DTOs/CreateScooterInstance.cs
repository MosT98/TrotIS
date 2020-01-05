using MediatR;
using ScooterInstanceAPI.Data;

namespace ScooterInstanceAPI.DTOs
{
    public class CreateScooterInstance : IRequest<ScooterInstance>
    {
        public int ScooterAutonomy { get; set; } //km

        public System.Guid Scooter { get; set; }
    }
}
