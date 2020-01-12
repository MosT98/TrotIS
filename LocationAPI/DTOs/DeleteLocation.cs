using MediatR;
using System;

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
