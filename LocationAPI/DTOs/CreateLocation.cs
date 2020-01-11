using LocationAPI.Data;
using MediatR;

namespace LocationAPI.DTOs
{
    public class CreateLocation: IRequest<Location>
    {
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public string Comment { get; set; }
    }
}
