using MediatR;
using System;
using UserAPI.Data;

namespace UserAPI.DTOs
{
    public class GetUserDetail: IRequest<User>
    {
        public GetUserDetail(Guid id)
        {
            UserId = id;
        }

        public Guid UserId { get; }
    }
}
