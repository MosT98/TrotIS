using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationAPI.DTOs
{
    public class DeleteLocation: IRequest
    {
        public Guid LocationId { get; set; }
    }
}
