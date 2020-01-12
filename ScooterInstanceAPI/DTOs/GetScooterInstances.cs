using System;
using System.Collections.Generic;
using MediatR;
using ScooterInstanceAPI.Data;

namespace ScooterInstanceAPI.DTOs
{
    public class GetScooterInstances : IRequest<List<ScooterInstance>>
    {
        public List<Guid> ScooterList { get; set; }
        public GetScooterInstances(List<Guid> ids)
        {
            ScooterList = ids;
        }
    }
}
