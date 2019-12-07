using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Data;

namespace UserAPI.DTOs
{
    public class GetUsers: IRequest<List<User>>
    {

    }
}
