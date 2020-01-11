using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationAPI.DTOs
{
    public class DeleteLocation: IRequest
    {
        public DeleteLocation(Guid Id)
        {
            LocationID = Id;
        }
        public Guid LocationID { get; set; }
    }
}
