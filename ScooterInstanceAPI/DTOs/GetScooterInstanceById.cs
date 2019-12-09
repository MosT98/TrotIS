using System;
using MediatR;
using ScooterInstanceAPI.Data;

namespace ScooterInstanceAPI.DTOs
{
    public class GetScooterInstanceById : IRequest<ScooterInstance>
    {
        public Guid ScooterInstanceId { get; set; }
        public GetScooterInstanceById(Guid id)
        {
            ScooterInstanceId = id;
        }
    }
}
