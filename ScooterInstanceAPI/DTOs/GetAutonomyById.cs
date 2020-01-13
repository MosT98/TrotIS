using System;
using MediatR;

namespace ScooterInstanceAPI.DTOs
{
    public class GetAutonomyById : IRequest<int>
    {
        public Guid ScooterInstanceId { get; set; }
        public GetAutonomyById(Guid id)
        {
            ScooterInstanceId = id;
        }
    }
}
