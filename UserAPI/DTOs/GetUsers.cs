using MediatR;
using System.Collections.Generic;
using UserAPI.Data;

namespace UserAPI.DTOs
{
    public class GetUsers: IRequest<List<User>>
    {

    }
}
