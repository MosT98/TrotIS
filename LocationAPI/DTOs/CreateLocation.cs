using LocationAPI.Data;
using MediatR;

namespace LocationAPI.DTOs
{
    public class CreateLocation: IRequest<Location>
    {
        public string addressID { get; set; }
    }
}
