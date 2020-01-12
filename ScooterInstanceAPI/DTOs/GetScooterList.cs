using System;
using System.Collections.Generic;
using MediatR;
using ScooterInstanceAPI.Data;

namespace ScooterInstanceAPI.DTOs
{
    public class GetScooterList : IRequest<List<Scooter>>
    {
        public List<Guid> ScooterInstancesList { get; set; }
        public GetScooterList(List<Guid> ids)
        {
            ScooterInstancesList = ids;
        }
    }
}
