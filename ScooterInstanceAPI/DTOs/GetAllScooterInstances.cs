using MediatR;
using ScooterInstanceAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScooterInstanceAPI.DTOs
{
    public class GetAllScooterInstances : IRequest<List<ScooterInstance>>
    {

    }
}
