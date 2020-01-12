using System;
using System.Collections.Generic;
using MediatR;
using ScooterInstanceAPI.Data;

namespace ScooterInstanceAPI.DTOs
{
    public class GetScooterInstanceList : IRequest<List<ScooterInstance>>
    {
        public List<Guid> ScooterInstanceList { get; set; }
        public GetScooterInstanceList(List<Guid> ids)
        {
            ScooterInstanceList = ids;
        }
    }
}
