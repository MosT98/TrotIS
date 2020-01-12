using System;
using MediatR;

namespace ScooterInstanceAPI.DTOs
{
    public class DeleteScooterInstance : IRequest
    {
        public Guid ScooterInstanceId { get; set; }

        public DeleteScooterInstance(Guid scooterInstanceId)
        {
            ScooterInstanceId = scooterInstanceId;
        }
    }
}
