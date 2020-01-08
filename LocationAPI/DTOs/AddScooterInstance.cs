using LocationAPI.Data;
using MediatR;

namespace LocationAPI.DTOs
{
    public class AddScooterInstance: IRequest<LocationsToScooters>
    {
        public string locationID { get; set; }
        public string scooterInstanceID { get; set; }
    }
}
