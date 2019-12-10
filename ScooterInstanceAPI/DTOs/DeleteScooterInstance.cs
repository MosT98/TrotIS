using System;
using MediatR;

namespace ScooterInstanceAPI.DTOs
{
    public class DeleteScooterInstance : IRequest
    {
        public Guid ScooterInstanceId { get; set; }
    }
}
